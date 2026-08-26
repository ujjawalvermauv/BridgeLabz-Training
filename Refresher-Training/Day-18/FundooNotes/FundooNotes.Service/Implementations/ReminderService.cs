using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Interfaces;

namespace FundooNotes.Service.Implementations;

public class ReminderService : IReminderService
{
    private readonly IReminderRepository _reminderRepository;
    private readonly INoteRepository _noteRepository;
    private readonly IUserRepository _userRepository;
    private readonly IRabbitMQService _rabbitMQService;

    public ReminderService(
        IReminderRepository reminderRepository,
        INoteRepository noteRepository,
        IUserRepository userRepository,
        IRabbitMQService rabbitMQService)
    {
        _reminderRepository = reminderRepository;
        _noteRepository = noteRepository;
        _userRepository = userRepository;
        _rabbitMQService = rabbitMQService;
    }

    public async Task<Reminder?> CreateReminderAsync(CreateReminderDto request, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(request.NoteId, userId);
        if (note == null || note.IsTrashed)
        {
            return null; // Note doesn't exist or is trashed
        }

        var reminder = new Reminder
        {
            NoteId = request.NoteId,
            UserId = userId,
            ReminderTime = request.ReminderTime,
            IsCompleted = false
        };

        var createdReminder = await _reminderRepository.CreateAsync(reminder);

        var user = await _userRepository.GetByIdAsync(userId);
        
        if (user != null)
        {
            var message = new ReminderMessage
            {
                ReminderId = createdReminder.Id,
                UserId = userId,
                NoteId = createdReminder.NoteId,
                ReminderTime = createdReminder.ReminderTime,
                Email = user.Email
            };

            _rabbitMQService.PublishReminder(message);
        }

        return createdReminder;
    }

    public async Task<Reminder?> GetByIdAsync(int id, int userId)
    {
        return await _reminderRepository.GetByIdAsync(id, userId);
    }

    public async Task<List<Reminder>> GetAllAsync(int userId)
    {
        return await _reminderRepository.GetAllByUserIdAsync(userId);
    }

    public async Task<bool> DeleteAsync(int id, int userId)
    {
        var reminder = await _reminderRepository.GetByIdAsync(id, userId);
        if (reminder == null) return false;

        await _reminderRepository.DeleteAsync(reminder);
        return true;
    }
}
