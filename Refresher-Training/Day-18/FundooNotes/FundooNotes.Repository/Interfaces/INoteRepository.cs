using FundooNotes.Models.Entities;

namespace FundooNotes.Repository.Interfaces;

public interface INoteRepository
{
    Task<Note> CreateAsync(Note note);

    Task<List<Note>> GetByUserIdAsync(int userId);

    Task<Note?> GetByIdAsync(int id, int userId);

    Task UpdateAsync(Note note);

    Task DeleteAsync(Note note);

    Task<List<Note>> GetArchivedByUserIdAsync(int userId);

    Task<List<Note>> GetTrashedByUserIdAsync(int userId);

    Task<List<Note>> SearchAsync(int userId, string keyword);

    Task<List<Note>> FilterAsync(int userId, bool? isPinned, bool? isArchived, bool? isTrashed);

    Task<bool> AddLabelAsync(int noteId, int labelId, int userId);

    Task<bool> RemoveLabelAsync(int noteId, int labelId, int userId);

    Task<List<Note>> GetNotesByLabelAsync(int labelId, int userId);
}