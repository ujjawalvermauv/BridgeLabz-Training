using System.Net;
using System.Net.Mail;
using FundooNotes.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FundooNotes.Service.Implementations;

public class SmtpService : ISmtpService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<SmtpService> _logger;

    public SmtpService(IConfiguration configuration, ILogger<SmtpService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public async Task SendReminderEmailAsync(string toEmail, string subject, string body)
    {
        try
        {
            var smtpConfig = _configuration.GetSection("Smtp");
            var host = smtpConfig["Host"];
            var port = int.Parse(smtpConfig["Port"] ?? "587");
            var username = smtpConfig["Username"];
            var password = smtpConfig["Password"];
            var fromEmail = smtpConfig["FromEmail"];

            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username))
            {
                _logger.LogWarning("SMTP configuration is incomplete. Skipping email sending.");
                return;
            }

            using var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage(fromEmail!, toEmail, subject, body);

            await client.SendMailAsync(mailMessage);
            _logger.LogInformation("Successfully sent reminder email to {Email}", toEmail);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send reminder email to {Email}", toEmail);
        }
    }
}
