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
        await _context.Notes.AddAsync(note);
        await _context.SaveChangesAsync();

        return note;
    }

    public async Task<List<Note>> GetByUserIdAsync(int userId)
    {
        return await _context.Notes
            .Where(n => n.UserId == userId && !n.IsTrashed && !n.IsArchived)
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

    public async Task<List<Note>> GetArchivedByUserIdAsync(int userId)
    {
        return await _context.Notes
            .Where(n => n.UserId == userId && n.IsArchived && !n.IsTrashed)
            .ToListAsync();
    }

    public async Task<List<Note>> GetTrashedByUserIdAsync(int userId)
    {
        return await _context.Notes
            .Where(n => n.UserId == userId && n.IsTrashed)
            .ToListAsync();
    }

    public async Task<List<Note>> SearchAsync(int userId, string keyword)
    {
        return await _context.Notes
            .Where(n => n.UserId == userId && !n.IsTrashed && 
                       (n.Title.Contains(keyword) || n.Description.Contains(keyword)))
            .ToListAsync();
    }

    public async Task<List<Note>> FilterAsync(int userId, bool? isPinned, bool? isArchived, bool? isTrashed)
    {
        var query = _context.Notes.Where(n => n.UserId == userId).AsQueryable();

        if (isPinned.HasValue)
            query = query.Where(n => n.IsPinned == isPinned.Value);
            
        if (isArchived.HasValue)
            query = query.Where(n => n.IsArchived == isArchived.Value);
            
        if (isTrashed.HasValue)
            query = query.Where(n => n.IsTrashed == isTrashed.Value);

        return await query.ToListAsync();
    }
}