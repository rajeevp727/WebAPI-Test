using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Test.Models;
using WebAPI_Test.Repositories;

namespace WebAPI_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _contactRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            return await _contactRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact([FromBody] Contact c)
        {
            var newContact = await _contactRepository.Create(c);
            return CreatedAtAction(nameof(GetContact), new { id = newContact.id }, newContact);
        }

        [HttpPut]
        public async Task<ActionResult> PutContact(int id, [FromBody] Contact c)
        {
            if (id != c.id)
            {
                return BadRequest();
            }
            await _contactRepository.Update(c);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContact(int id)
        {
            var contactToDelete = await _contactRepository.Get(id);
            if (contactToDelete == null)
            {
                return NotFound();
            }
            await _contactRepository.Delete(contactToDelete.id);
            return NoContent();
        }
    }
}
