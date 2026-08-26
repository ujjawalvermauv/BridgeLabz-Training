using System.Security.Claims;
using FundooNotes.Models.DTOs;
using FundooNotes.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class NoteController : ControllerBase
{
    private readonly INoteService _noteService;

    public NoteController(INoteService noteService)
    {
        _noteService = noteService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(NoteRequest request)
    {
        var userId = GetUserId();

        var result = await _noteService.CreateAsync(request, userId);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var userId = GetUserId();

        var result = await _noteService.GetAllAsync(userId);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var userId = GetUserId();

        var result = await _noteService.GetByIdAsync(id, userId);

        if (result == null)
        {
            return NotFound("Note not found.");
        }

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        int id,
        NoteRequest request)
    {
        var userId = GetUserId();

        var result =
            await _noteService.UpdateAsync(id, request, userId);

        if (!result)
        {
            return NotFound("Note not found.");
        }

        return Ok("Note updated successfully.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var userId = GetUserId();

        var result =
            await _noteService.DeleteAsync(id, userId);

        if (!result)
        {
            return NotFound("Note not found.");
        }

        return Ok("Note deleted successfully.");
    }

    [HttpPut("{id}/pin")]
    public async Task<IActionResult> TogglePin(int id)
    {
        var result = await _noteService.TogglePinAsync(id, GetUserId());
        return result ? Ok("Pin status toggled.") : NotFound("Note not found or trashed.");
    }

    [HttpPut("{id}/archive")]
    public async Task<IActionResult> ToggleArchive(int id)
    {
        var result = await _noteService.ToggleArchiveAsync(id, GetUserId());
        return result ? Ok("Archive status toggled.") : NotFound("Note not found or trashed.");
    }

    [HttpPut("{id}/trash")]
    public async Task<IActionResult> Trash(int id)
    {
        var result = await _noteService.TrashAsync(id, GetUserId());
        return result ? Ok("Note moved to trash.") : NotFound("Note not found.");
    }

    [HttpPut("{id}/restore")]
    public async Task<IActionResult> Restore(int id)
    {
        var result = await _noteService.RestoreAsync(id, GetUserId());
        return result ? Ok("Note restored from trash.") : NotFound("Note not found or not in trash.");
    }

    [HttpGet("archive")]
    public async Task<IActionResult> GetArchived()
    {
        var result = await _noteService.GetArchivedAsync(GetUserId());
        return Ok(result);
    }

    [HttpGet("trash")]
    public async Task<IActionResult> GetTrashed()
    {
        var result = await _noteService.GetTrashedAsync(GetUserId());
        return Ok(result);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword)) return BadRequest("Keyword is required.");
        var result = await _noteService.SearchAsync(GetUserId(), keyword);
        return Ok(result);
    }

    [HttpGet("filter")]
    public async Task<IActionResult> Filter([FromQuery] bool? isPinned, [FromQuery] bool? isArchived, [FromQuery] bool? isTrashed)
    {
        var result = await _noteService.FilterAsync(GetUserId(), isPinned, isArchived, isTrashed);
        return Ok(result);
    }

    private int GetUserId()
    {
        return int.Parse(
            User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    }
}