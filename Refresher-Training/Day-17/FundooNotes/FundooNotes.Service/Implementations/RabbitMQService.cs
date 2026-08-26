using System.Text;
using System.Text.Json;
using FundooNotes.Models.DTOs;
using FundooNotes.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;

namespace FundooNotes.Service.Implementations;

public class RabbitMQService : IRabbitMQService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<RabbitMQService> _logger;

    public RabbitMQService(IConfiguration configuration, ILogger<RabbitMQService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public void PublishReminder(ReminderMessage message)
    {
        try
        {
            var rabbitConfig = _configuration.GetSection("RabbitMQ");
            var factory = new ConnectionFactory
            {
                HostName = rabbitConfig["Host"] ?? "localhost",
                UserName = rabbitConfig["UserName"] ?? "guest",
                Password = rabbitConfig["Password"] ?? "guest"
            };

            var queueName = rabbitConfig["QueueName"] ?? "reminder_queue";

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var messageJson = JsonSerializer.Serialize(message);
            var body = Encoding.UTF8.GetBytes(messageJson);

            channel.BasicPublish(exchange: "",
                                 routingKey: queueName,
                                 basicProperties: null,
                                 body: body);
                                 
            _logger.LogInformation("Successfully published reminder message to RabbitMQ for NoteId: {NoteId}", message.NoteId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to publish reminder message to RabbitMQ.");
        }
    }
}
