using Infrastructure.Data.Contexts;
using Infrastructure.Data.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace WebApi_ContactForm.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpPost]
    public async Task<IActionResult> Create(Contact contact)
    {
        if (ModelState.IsValid)
        {
            if (!await _context.Contacts.AnyAsync(x => x.Email == contact.Email))
            {
                var entity = new ContactEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = contact.FullName,
                    Email = contact.Email,
                    HiddenSelectInput = contact.HiddenSelectInput,
                    Message = contact.Message
                };
                _context.Contacts.Add(entity);
                await _context.SaveChangesAsync();
                return Created("", null);
            }

            return Conflict();
        }

        return BadRequest();
    }
    
}

/*[HttpPost]
    public async Task<IActionResult> Create(ContactRegistrationForm contact)
    {
        if (ModelState.IsValid)
        {
            if (!await _context.Contacts.AnyAsync(x => x.Email == contact.Email))
            {
                var entity = ContactFactory.Create(contact);

                _context.Contacts.Add(entity);
                await _context.SaveChangesAsync();
                return Created("", null);
            }


            return Conflict();
        }
        return BadRequest();
    }*/