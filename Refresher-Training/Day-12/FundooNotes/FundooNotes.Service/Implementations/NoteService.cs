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

    public async Task<NoteRequest> CreateAsync(
        NoteRequest request,
        int userId)
    {
        var note = new Note
        {
            Title = request.Title,
            Description = request.Description,
            UserId = userId,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        var createdNote = await _noteRepository.CreateAsync(note);

        return new NoteRequest
        {
            Title = createdNote.Title,
            Description = createdNote.Description
        };
    }

    public async Task<List<NoteRequest>> GetAllAsync(int userId)
    {
        var notes = await _noteRepository.GetByUserIdAsync(userId);

        return notes.Select(note => new NoteRequest
        {
            Title = note.Title,
            Description = note.Description
        }).ToList();
    }

    public async Task<NoteRequest?> GetByIdAsync(
        int id,
        int userId)
    {
        var note = await _noteRepository.GetByIdAsync(id, userId);

        if (note == null)
        {
            return null;
        }

        return new NoteRequest
        {
            Title = note.Title,
            Description = note.Description
        };
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
}