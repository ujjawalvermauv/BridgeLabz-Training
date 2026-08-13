using Day9_EntityContact.Models;
using Day9_EntityContact.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day9_EntityContact.Controllers
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
        public IActionResult GetContacts()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            Contact? contact = service.GetById(id);

            if (contact == null)
            {
                return NotFound("Contact not found");
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            service.Add(contact);

            return Ok("Contact created successfully");
        }

        [HttpPut("{id}")]
        public IActionResult EditContact(int id, Contact contact)
        {
            Contact? existingContact = service.GetById(id);

            if (existingContact == null)
            {
                return NotFound("Contact not found");
            }

            contact.Id = id;

            service.Update(contact);

            return Ok("Contact updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveContact(int id)
        {
            Contact? existingContact = service.GetById(id);

            if (existingContact == null)
            {
                return NotFound("Contact not found");
            }

            service.Delete(id);

            return Ok("Contact deleted successfully");
        }
    }
}