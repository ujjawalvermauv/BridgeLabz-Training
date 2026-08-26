using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface IRabbitMQService
{
    void PublishReminder(ReminderMessage message);
}
