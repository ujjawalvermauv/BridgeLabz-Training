using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;

namespace FundooNotes.Service.Interfaces;

public interface IReminderService
{
    Task<Reminder?> CreateReminderAsync(CreateReminderDto request, int userId);
    Task<Reminder?> GetByIdAsync(int id, int userId);
    Task<List<Reminder>> GetAllAsync(int userId);
    Task<bool> DeleteAsync(int id, int userId);
}
