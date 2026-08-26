using FundooNotes.Models.Entities;
using FundooNotes.Repository.Data;
using FundooNotes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Repository.Implementations;

public class ReminderRepository : IReminderRepository
{
    private readonly FundooDbContext _context;

    public ReminderRepository(FundooDbContext context)
    {
        _context = context;
    }

    public async Task<Reminder> CreateAsync(Reminder reminder)
    {
        await _context.Reminders.AddAsync(reminder);
        await _context.SaveChangesAsync();
        return reminder;
    }

    public async Task<Reminder?> GetByIdAsync(int id, int userId)
    {
        return await _context.Reminders
            .FirstOrDefaultAsync(r => r.Id == id && r.UserId == userId);
    }

    public async Task<List<Reminder>> GetAllByUserIdAsync(int userId)
    {
        return await _context.Reminders
            .Where(r => r.UserId == userId)
            .ToListAsync();
    }

    public async Task DeleteAsync(Reminder reminder)
    {
        _context.Reminders.Remove(reminder);
        await _context.SaveChangesAsync();
    }
}
