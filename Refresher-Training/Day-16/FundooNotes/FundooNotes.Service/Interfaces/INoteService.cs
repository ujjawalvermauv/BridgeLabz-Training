using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface INoteService
{
    Task<NoteResponse> CreateAsync(NoteRequest request, int userId);

    Task<List<NoteResponse>> GetAllAsync(int userId);

    Task<NoteResponse?> GetByIdAsync(int id, int userId);

    Task<bool> UpdateAsync(int id, NoteRequest request, int userId);

    Task<bool> DeleteAsync(int id, int userId);

    Task<bool> TogglePinAsync(int id, int userId);

    Task<bool> ToggleArchiveAsync(int id, int userId);

    Task<bool> TrashAsync(int id, int userId);

    Task<bool> RestoreAsync(int id, int userId);

    Task<List<NoteResponse>> GetArchivedAsync(int userId);

    Task<List<NoteResponse>> GetTrashedAsync(int userId);

    Task<List<NoteResponse>> SearchAsync(int userId, string keyword);

    Task<List<NoteResponse>> FilterAsync(int userId, bool? isPinned, bool? isArchived, bool? isTrashed);

    Task<bool> AddLabelAsync(int noteId, int labelId, int userId);

    Task<bool> RemoveLabelAsync(int noteId, int labelId, int userId);

    Task<List<NoteResponse>> GetNotesByLabelAsync(int labelId, int userId);
}