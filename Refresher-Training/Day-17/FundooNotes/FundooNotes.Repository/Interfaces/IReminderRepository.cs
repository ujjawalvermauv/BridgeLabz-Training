using FundooNotes.Models.Entities;

namespace FundooNotes.Repository.Interfaces;

public interface IReminderRepository
{
    Task<Reminder> CreateAsync(Reminder reminder);
    Task<Reminder?> GetByIdAsync(int id, int userId);
    Task<List<Reminder>> GetAllByUserIdAsync(int userId);
    Task DeleteAsync(Reminder reminder);
}
