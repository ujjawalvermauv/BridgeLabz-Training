using Day10_AddressBookAPI.Models;
using Day10_AddressBookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day10_AddressBookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService service;

        public AddressController(IAddressService service)
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
            AddressEntry? entry = service.GetById(id);

            if (entry == null)
            {
                return NotFound("Address entry not found");
            }

            return Ok(entry);
        }

        [HttpPost]
        public IActionResult Add(AddressEntry entry)
        {
            service.Add(entry);

            return Ok("Address added successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AddressEntry entry)
        {
            AddressEntry? existingEntry = service.GetById(id);

            if (existingEntry == null)
            {
                return NotFound("Address entry not found");
            }

            entry.Id = id;

            service.Update(entry);

            return Ok("Address updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AddressEntry? existingEntry = service.GetById(id);

            if (existingEntry == null)
            {
                return NotFound("Address entry not found");
            }

            service.Delete(id);

            return Ok("Address deleted successfully");
        }
    }
}