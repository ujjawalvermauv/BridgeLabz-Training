using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface INoteService
{
    Task<NoteRequest> CreateAsync(NoteRequest request, int userId);

    Task<List<NoteRequest>> GetAllAsync(int userId);

    Task<NoteRequest?> GetByIdAsync(int id, int userId);

    Task<bool> UpdateAsync(int id, NoteRequest request, int userId);

    Task<bool> DeleteAsync(int id, int userId);
}