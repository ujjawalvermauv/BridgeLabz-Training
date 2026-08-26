namespace FundooNotes.Service.Interfaces;

public interface ISmtpService
{
    Task SendReminderEmailAsync(string toEmail, string subject, string body);
}
