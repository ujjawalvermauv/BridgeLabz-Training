using FundooNotes.Models.Entities;

namespace FundooNotes.Repository.Interfaces;

public interface INoteRepository
{
    Task<Note> CreateAsync(Note note);

    Task<List<Note>> GetByUserIdAsync(int userId);

    Task<Note?> GetByIdAsync(int id, int userId);

    Task UpdateAsync(Note note);

    Task DeleteAsync(Note note);
}