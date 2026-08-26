using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Interfaces;

namespace FundooNotes.Service.Implementations;

public class NoteService : INoteService
{
    private readonly INoteRepository _noteRepository;

    public NoteService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

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

        return MapToResponse(note);
    }

    public async Task<List<NoteResponse>> GetAllAsync(int userId)
    {
        var notes = await _noteRepository.GetByUserIdAsync(userId);

        return notes.Select(MapToResponse).ToList();
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

        return true;
    }

    public async Task<bool> TogglePinAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || note.IsTrashed) return false;

        note.IsPinned = !note.IsPinned;
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
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
        return true;
    }

    public async Task<bool> RestoreAsync(int id, int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);
        if (note == null || !note.IsTrashed) return false;

        note.IsTrashed = false;
        note.UpdatedAt = DateTime.UtcNow;
        await _noteRepository.UpdateAsync(note);
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