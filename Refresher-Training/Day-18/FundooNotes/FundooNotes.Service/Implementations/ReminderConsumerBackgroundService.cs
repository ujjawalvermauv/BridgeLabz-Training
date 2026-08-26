using System.Text;
using System.Text.Json;
using FundooNotes.Models.DTOs;
using FundooNotes.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace FundooNotes.Service.Implementations;

public class ReminderConsumerBackgroundService : BackgroundService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<ReminderConsumerBackgroundService> _logger;
    private readonly IServiceProvider _serviceProvider;
    private IConnection? _connection;
    private IModel? _channel;

    public ReminderConsumerBackgroundService(
        IConfiguration configuration,
        ILogger<ReminderConsumerBackgroundService> logger,
        IServiceProvider serviceProvider)
    {
        _configuration = configuration;
        _logger = logger;
        _serviceProvider = serviceProvider;
        InitializeRabbitMQ();
    }

    private void InitializeRabbitMQ()
    {
        try
        {
            var rabbitConfig = _configuration.GetSection("RabbitMQ");
            var factory = new ConnectionFactory
            {
                HostName = rabbitConfig["Host"] ?? "localhost",
                UserName = rabbitConfig["UserName"] ?? "guest",
                Password = rabbitConfig["Password"] ?? "guest",
                DispatchConsumersAsync = true // Enable async dispatch
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            var queueName = rabbitConfig["QueueName"] ?? "reminder_queue";

            _channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
                                 
            _logger.LogInformation("Connected to RabbitMQ.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to connect to RabbitMQ in BackgroundService.");
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (_channel == null)
        {
            _logger.LogWarning("RabbitMQ channel is not initialized. Background service stopping.");
            return;
        }

        var queueName = _configuration["RabbitMQ:QueueName"] ?? "reminder_queue";

        var consumer = new AsyncEventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            try
            {
                var body = ea.Body.ToArray();
                var messageString = Encoding.UTF8.GetString(body);
                var message = JsonSerializer.Deserialize<ReminderMessage>(messageString);

                if (message != null)
                {
                    _logger.LogInformation("Received reminder message for NoteId: {NoteId}", message.NoteId);
                    
                    var delay = message.ReminderTime - DateTime.UtcNow;
                    if (delay > TimeSpan.Zero)
                    {
                        await Task.Delay(delay, stoppingToken);
                    }

                    using var scope = _serviceProvider.CreateScope();
                    var smtpService = scope.ServiceProvider.GetRequiredService<ISmtpService>();
                    
                    var subject = "FundooNotes Reminder";
                    var emailBody = $"You have a reminder for your note (ID: {message.NoteId}).";
                    
                    await smtpService.SendReminderEmailAsync(message.Email, subject, emailBody);
                    _logger.LogInformation("Reminder email sent for NoteId: {NoteId}", message.NoteId);
                }

                _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing reminder message.");
                // Nack the message or just ack to drop it in a simple implementation to avoid infinite loops
                _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: false);
            }
        };

        _channel.BasicConsume(queue: queueName,
                             autoAck: false,
                             consumer: consumer);

        await Task.CompletedTask;
    }

    public override void Dispose()
    {
        _channel?.Dispose();
        _connection?.Dispose();
        base.Dispose();
    }
}
