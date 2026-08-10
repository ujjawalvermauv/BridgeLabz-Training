using Microsoft.AspNetCore.Mvc;
using GreetingApp.Models;

namespace GreetingApp.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Greeting greeting)
        {
            greeting.Message = $"Hello, {greeting.Name}! Welcome to Greeting App.";

            return View(greeting);
        }
    }
}