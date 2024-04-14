using Infrastructure.Data.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(ApiContext context) : ControllerBase
    {
        private readonly ApiContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll(string category="", string searchQuery="", int pageNumber= 1, int pageSize= 6)
        {
            var query = _context.Courses
                .Include(i => i.Category)
                .AsQueryable();

            if(!string.IsNullOrEmpty(searchQuery) )
                query = query.Where(x=> x.Author.Contains(searchQuery)|| x.Title.Contains(searchQuery) ||x.OriginalPrice.Contains(searchQuery));

            if(!string.IsNullOrEmpty(category) && category != "all")
                query = query.Where(x => x.Category!.CategoryName == category);
            
            query = query.OrderByDescending(o => o.Created);


            var totalItemCount = await query.CountAsync();
            var totolPages =(int)Math.Ceiling(totalItemCount/(double)pageSize);
            var courses = await query.Skip((pageNumber-1) *pageSize).Take(pageSize).ToListAsync();

            var result = new CourseResult
            {
                TotalItems =  totalItemCount,
                TotalPages =totolPages ,
                Courses = CourseFactory.Create(courses),
            };
            
            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAsync (string id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x=> x.Id == id);

            if(course == null)
            {
                return NotFound();
            }

            var singleCourse = new SingleCourse
            {
                Id = id,
                Title = course.Title,
                Author = course.Author,
                OriginalPrice = course.OriginalPrice,
                Hours = course.Hours,
                IsBestseller = course.IsBestseller,
                IsDigital = course.IsDigital,
                LikesInProcent = course.LikesInProcent,
                NumberofLikes = course.NumberofLikes,
                DiscountedPrice = course.DiscountedPrice,
                CourseDescription = course.CourseDescription,
                learn1 = course.learn1,
                learn2 = course.learn2,
                learn3 = course.learn3,
                learn4 = course.learn4,
                learn5 = course.learn5,
                programdetails1 = course.programdetails1,
                programdetails2 = course.programdetails2,
                programdetails3 = course.programdetails3,
                programdetails4 = course.programdetails4,
                programdetails5 = course.programdetails5,
                programdetails6 = course.programdetails6,

            };

            return Ok(singleCourse);
        }


    }
}
