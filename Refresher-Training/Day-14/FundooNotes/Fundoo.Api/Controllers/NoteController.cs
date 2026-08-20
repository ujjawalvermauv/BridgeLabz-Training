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

    private int GetUserId()
    {
        return int.Parse(
            User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    }
}