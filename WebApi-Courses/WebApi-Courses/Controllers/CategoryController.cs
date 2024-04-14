using Infrastructure.Data.Contexts;
using Infrastructure.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ApiContext context) : ControllerBase
    {
        private readonly ApiContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _context.Categories.OrderBy(e => e.CategoryName).ToListAsync();  
            return Ok(CategoryFactory.Create(categories));
        }
    }
}
 