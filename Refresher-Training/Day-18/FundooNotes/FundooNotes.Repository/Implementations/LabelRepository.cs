using FundooNotes.Models.Entities;
using FundooNotes.Repository.Data;
using FundooNotes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Repository.Implementations;

public class LabelRepository : ILabelRepository
{
    private readonly FundooDbContext _context;

    public LabelRepository(FundooDbContext context)
    {
        _context = context;
    }

    public async Task<Label> CreateAsync(Label label)
    {
        await _context.Labels.AddAsync(label);
        await _context.SaveChangesAsync();
        return label;
    }

    public async Task<List<Label>> GetByUserIdAsync(int userId)
    {
        return await _context.Labels
            .Where(l => l.UserId == userId)
            .ToListAsync();
    }

    public async Task<Label?> GetByIdAsync(int id, int userId)
    {
        return await _context.Labels
            .FirstOrDefaultAsync(l => l.Id == id && l.UserId == userId);
    }

    public async Task UpdateAsync(Label label)
    {
        _context.Labels.Update(label);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Label label)
    {
        _context.Labels.Remove(label);
        await _context.SaveChangesAsync();
    }
}
