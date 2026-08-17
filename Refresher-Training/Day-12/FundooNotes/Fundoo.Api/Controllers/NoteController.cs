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

        if (userId == null)
        {
            return Unauthorized();
        }

        var note = await _noteService.CreateAsync(
            request,
            userId.Value);

        return Ok(note);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var userId = GetUserId();

        if (userId == null)
        {
            return Unauthorized();
        }

        var notes = await _noteService.GetAllAsync(
            userId.Value);

        return Ok(notes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var userId = GetUserId();

        if (userId == null)
        {
            return Unauthorized();
        }

        var note = await _noteService.GetByIdAsync(
            id,
            userId.Value);

        if (note == null)
        {
            return NotFound("Note not found.");
        }

        return Ok(note);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        int id,
        NoteRequest request)
    {
        var userId = GetUserId();

        if (userId == null)
        {
            return Unauthorized();
        }

        var updated = await _noteService.UpdateAsync(
            id,
            request,
            userId.Value);

        if (!updated)
        {
            return NotFound("Note not found.");
        }

        return Ok("Note updated successfully.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var userId = GetUserId();

        if (userId == null)
        {
            return Unauthorized();
        }

        var deleted = await _noteService.DeleteAsync(
            id,
            userId.Value);

        if (!deleted)
        {
            return NotFound("Note not found.");
        }

        return Ok("Note deleted successfully.");
    }

    private int? GetUserId()
    {
        var userIdClaim = User.FindFirst(
            ClaimTypes.NameIdentifier);

        if (userIdClaim == null)
        {
            return null;
        }

        if (!int.TryParse(
                userIdClaim.Value,
                out var userId))
        {
            return null;
        }

        return userId;
    }
}