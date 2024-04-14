using Infrastructure.Data.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi_ContactForm.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OptionController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpGet]
    public async Task <IActionResult> GetAllOptions()
    {
        var options = await _context.Options.OrderBy(e => e.Id).ToListAsync();
        return Ok(OptionFactory.Create(options));
    }

}
