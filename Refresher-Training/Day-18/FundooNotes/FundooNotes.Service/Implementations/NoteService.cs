using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Interfaces;

namespace FundooNotes.Service.Implementations;

public class NoteService : INoteService
{
    private readonly INoteRepository _noteRepository;
    private readonly ICacheService? _cache;

    public NoteService(INoteRepository noteRepository, ICacheService? cache = null)
    {
        _noteRepository = noteRepository;
        _cache = cache;
    }

    private static string CacheKey(int userId) => $"notes:recent:{userId}";

    public async Task<NoteResponse> CreateAsync(
        NoteRequest request,
        int userId)
    {
        var note = new Note
        {
            Title = request.Title,
            Description = request.Description,
            UserId = userId,
            CreatedAt = DateTime.UtcNow
        };

        await _noteRepository.CreateAsync(note);

        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));

        return MapToResponse(note);
    }

    public async Task<List<NoteResponse>> GetAllAsync(int userId)
    {
        var notes = await _noteRepository.GetByUserIdAsync(userId);

        return notes.Select(MapToResponse).ToList();
    }

    public async Task<List<NoteResponse>> GetRecentNotesAsync(int userId)
    {
        if (_cache != null)
        {
            var cached = await _cache.GetAsync<List<NoteResponse>>(CacheKey(userId));
            if (cached != null) return cached;
        }

        var allNotes = await _noteRepository.GetByUserIdAsync(userId);
        var recent = allNotes.OrderByDescending(n => n.UpdatedAt).Take(5).Select(MapToResponse).ToList();

        if (_cache != null)
        {
            await _cache.SetAsync(CacheKey(userId), recent, TimeSpan.FromMinutes(5));
        }

        return recent;
    }

    public async Task<NoteResponse?> GetByIdAsync(
        int id,
        int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);

        if (note == null)
        {
            return null;
        }

        return MapToResponse(note);
    }

    public async Task<bool> UpdateAsync(
        int id,
        NoteRequest request,
        int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);

        if (note == null)
        {
            return false;
        }

        note.Title = request.Title;
        note.Description = request.Description;
        note.UpdatedAt = DateTime.UtcNow;

        await _noteRepository.UpdateAsync(note);

        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));

        return true;
    }

    public async Task<bool> DeleteAsync(
        int id,
        int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);

        if (note == null)
        {
            return false;
        }

        await _noteRepository.DeleteAsync(note);

        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));

        return true;
    }

    public async Task<bool> TogglePinAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || note.IsTrashed) return false;

        note.IsPinned = !note.IsPinned;
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));
        return true;
    }

    public async Task<bool> ToggleArchiveAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || note.IsTrashed) return false;

        note.IsArchived = !note.IsArchived;
        if (note.IsArchived) note.IsPinned = false; // Usually archived notes are unpinned
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));
        return true;
    }

    public async Task<bool> TrashAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || note.IsTrashed) return false;

        note.IsTrashed = true;
        note.IsPinned = false;
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));
        return true;
    }

    public async Task<bool> RestoreAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || !note.IsTrashed) return false;

        note.IsTrashed = false;
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
        if (_cache != null) await _cache.RemoveAsync(CacheKey(userId));
        return true;
    }

    public async Task<List<NoteResponse>> GetArchivedAsync(int userId)
    {
        var notes = await _noteRepository.GetArchivedByUserIdAsync(userId);
        return notes.Select(MapToResponse).ToList();
    }

    public async Task<List<NoteResponse>> GetTrashedAsync(int userId)
    {
        var notes = await _noteRepository.GetTrashedByUserIdAsync(userId);
        return notes.Select(MapToResponse).ToList();
    }

    public async Task<List<NoteResponse>> SearchAsync(int userId, string keyword)
    {
        var notes = await _noteRepository.SearchAsync(userId, keyword);
        return notes.Select(MapToResponse).ToList();
    }

    public async Task<List<NoteResponse>> FilterAsync(int userId, bool? isPinned, bool? isArchived, bool? isTrashed)
    {
        var notes = await _noteRepository.FilterAsync(userId, isPinned, isArchived, isTrashed);
        return notes.Select(MapToResponse).ToList();
    }

    public async Task<bool> AddLabelAsync(int noteId, int labelId, int userId)
    {
        return await _noteRepository.AddLabelAsync(noteId, labelId, userId);
    }

    public async Task<bool> RemoveLabelAsync(int noteId, int labelId, int userId)
    {
        return await _noteRepository.RemoveLabelAsync(noteId, labelId, userId);
    }

    public async Task<List<NoteResponse>> GetNotesByLabelAsync(int labelId, int userId)
    {
        var notes = await _noteRepository.GetNotesByLabelAsync(labelId, userId);
        return notes.Select(MapToResponse).ToList();
    }

    private NoteResponse MapToResponse(Note note)
    {
        return new NoteResponse
        {
            Id = note.Id,
            Title = note.Title,
            Description = note.Description,
            IsPinned = note.IsPinned,
            IsArchived = note.IsArchived,
            IsTrashed = note.IsTrashed,
            CreatedAt = note.CreatedAt,
            UpdatedAt = note.UpdatedAt
        };
    }
}