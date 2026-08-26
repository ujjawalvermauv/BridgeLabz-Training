using System.Security.Claims;
using FundooNotes.Models.DTOs;
using FundooNotes.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ReminderController : ControllerBase
{
    private readonly IReminderService _reminderService;

    public ReminderController(IReminderService reminderService)
    {
        _reminderService = reminderService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateReminderDto request)
    {
        if (request.ReminderTime <= DateTime.UtcNow)
        {
            return BadRequest("Reminder time must be in the future.");
        }

        var result = await _reminderService.CreateReminderAsync(request, GetUserId());
        if (result == null)
        {
            return BadRequest("Unable to create reminder. Note not found or not owned by you.");
        }

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _reminderService.GetByIdAsync(id, GetUserId());
        if (result == null) return NotFound("Reminder not found.");
        return Ok(result);
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _reminderService.GetAllAsync(GetUserId());
        return Ok(result);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _reminderService.DeleteAsync(id, GetUserId());
        if (!result) return NotFound("Reminder not found.");
        return Ok("Reminder deleted successfully.");
    }

    private int GetUserId()
    {
        return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    }
}
