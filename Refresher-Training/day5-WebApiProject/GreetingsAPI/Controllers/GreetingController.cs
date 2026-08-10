using Microsoft.AspNetCore.Mvc;

namespace GreetingsAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public IActionResult GetGreeting()
    {
        return Ok("Hello, Welcome to ASP.NET Core Web API!");
    }
}