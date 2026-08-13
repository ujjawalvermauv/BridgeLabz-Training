using Microsoft.AspNetCore.Mvc;
using Day8_ContactManagement.Models;
using Day8_ContactManagement.Services;

namespace Day8_ContactManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService service;

        public ContactController(IContactService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Contact contact = service.GetById(id);

            if (contact == null)
            {
                return NotFound("Contact not found");
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            service.Add(contact);

            return Ok("Contact added successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            Contact existingContact = service.GetById(id);

            if (existingContact == null)
            {
                return NotFound("Contact not found");
            }

            contact.Id = id;

            service.Update(contact);

            return Ok("Contact updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Contact existingContact = service.GetById(id);

            if (existingContact == null)
            {
                return NotFound("Contact not found");
            }

            service.Delete(id);

            return Ok("Contact deleted successfully");
        }
    }
}