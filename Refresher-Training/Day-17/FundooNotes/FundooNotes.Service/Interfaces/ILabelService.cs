using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface ILabelService
{
    Task<LabelResponse> CreateAsync(LabelRequest request, int userId);
    Task<List<LabelResponse>> GetAllAsync(int userId);
    Task<LabelResponse?> GetByIdAsync(int id, int userId);
    Task<bool> UpdateAsync(int id, LabelRequest request, int userId);
    Task<bool> DeleteAsync(int id, int userId);
}
