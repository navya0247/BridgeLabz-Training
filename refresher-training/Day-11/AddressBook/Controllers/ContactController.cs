using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.Dtos;

namespace AddressBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        // service injected here
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost("add")]
        public IActionResult AddContact(ContactDto contactDto)
        {
            var result = _contactService.AddContact(contactDto);
            return Ok(result);
        }

        [HttpGet("all")]
        public IActionResult GetAllContacts()
        {
            var result = _contactService.GetAllContacts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            var result = _contactService.GetContactById(id);
            if (result == null) return NotFound("Contact not found");
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, ContactDto contactDto)
        {
            var result = _contactService.UpdateContact(id, contactDto);
            if (result == null) return NotFound("Contact not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var result = _contactService.DeleteContact(id);
            if (!result) return NotFound("Contact not found");
            return Ok("Contact deleted successfully");
        }
    }
}