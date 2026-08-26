using FundooNotes.Models.Entities;

namespace FundooNotes.Repository.Interfaces;

public interface ILabelRepository
{
    Task<Label> CreateAsync(Label label);
    Task<List<Label>> GetByUserIdAsync(int userId);
    Task<Label?> GetByIdAsync(int id, int userId);
    Task UpdateAsync(Label label);
    Task DeleteAsync(Label label);
}
