using FundooNotes.Models.Entities;
using FundooNotes.Repository.Data;
using FundooNotes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Repository.Implementations;

public class NoteRepository : INoteRepository
{
    private readonly FundooDbContext _context;

    public NoteRepository(FundooDbContext context)
    {
        _context = context;
    }

    public async Task<Note> CreateAsync(Note note)
    {
        _context.Notes.Add(note);

        await _context.SaveChangesAsync();

        return note;
    }

    public async Task<List<Note>> GetByUserIdAsync(int userId)
    {
        return await _context.Notes
            .Where(n => n.UserId == userId)
            .ToListAsync();
    }

    public async Task<Note?> GetByIdAsync(int id, int userId)
    {
        return await _context.Notes
            .FirstOrDefaultAsync(n =>
                n.Id == id &&
                n.UserId == userId);
    }

    public async Task UpdateAsync(Note note)
    {
        _context.Notes.Update(note);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Note note)
    {
        _context.Notes.Remove(note);

        await _context.SaveChangesAsync();
    }
}