using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface INoteService
{
    Task<NoteResponse> CreateAsync(NoteRequest request, int userId);

    Task<List<NoteResponse>> GetAllAsync(int userId);

    Task<NoteResponse?> GetByIdAsync(int id, int userId);

    Task<bool> UpdateAsync(int id, NoteRequest request, int userId);

    Task<bool> DeleteAsync(int id, int userId);
}