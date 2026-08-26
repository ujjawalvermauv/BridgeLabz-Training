using System.Security.Claims;
using FundooNotes.Models.DTOs;
using FundooNotes.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class LabelController : ControllerBase
{
    private readonly ILabelService _labelService;
    private readonly INoteService _noteService;

    public LabelController(ILabelService labelService, INoteService noteService)
    {
        _labelService = labelService;
        _noteService = noteService;
    }

    [HttpGet("{id}/notes")]
    public async Task<IActionResult> GetNotesByLabel(int id)
    {
        var result = await _noteService.GetNotesByLabelAsync(id, GetUserId());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(LabelRequest request)
    {
        var result = await _labelService.CreateAsync(request, GetUserId());
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _labelService.GetAllAsync(GetUserId());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _labelService.GetByIdAsync(id, GetUserId());
        if (result == null) return NotFound("Label not found.");
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, LabelRequest request)
    {
        var result = await _labelService.UpdateAsync(id, request, GetUserId());
        if (!result) return NotFound("Label not found.");
        return Ok("Label updated successfully.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _labelService.DeleteAsync(id, GetUserId());
        if (!result) return NotFound("Label not found.");
        return Ok("Label deleted successfully.");
    }

    private int GetUserId()
    {
        return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    }
}
