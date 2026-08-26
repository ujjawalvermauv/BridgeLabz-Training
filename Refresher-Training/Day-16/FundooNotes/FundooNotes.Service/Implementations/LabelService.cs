using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Interfaces;

namespace FundooNotes.Service.Implementations;

public class LabelService : ILabelService
{
    private readonly ILabelRepository _labelRepository;

    public LabelService(ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public async Task<LabelResponse> CreateAsync(LabelRequest request, int userId)
    {
        var label = new Label
        {
            Name = request.Name,
            UserId = userId
        };

        await _labelRepository.CreateAsync(label);

        return new LabelResponse
        {
            Id = label.Id,
            Name = label.Name
        };
    }

    public async Task<List<LabelResponse>> GetAllAsync(int userId)
    {
        var labels = await _labelRepository.GetByUserIdAsync(userId);
        return labels.Select(l => new LabelResponse { Id = l.Id, Name = l.Name }).ToList();
    }

    public async Task<LabelResponse?> GetByIdAsync(int id, int userId)
    {
        var label = await _labelRepository.GetByIdAsync(id, userId);
        if (label == null) return null;
        return new LabelResponse { Id = label.Id, Name = label.Name };
    }

    public async Task<bool> UpdateAsync(int id, LabelRequest request, int userId)
    {
        var label = await _labelRepository.GetByIdAsync(id, userId);
        if (label == null) return false;

        label.Name = request.Name;
        await _labelRepository.UpdateAsync(label);
        return true;
    }

    public async Task<bool> DeleteAsync(int id, int userId)
    {
        var label = await _labelRepository.GetByIdAsync(id, userId);
        if (label == null) return false;

        await _labelRepository.DeleteAsync(label);
        return true;
    }
}
