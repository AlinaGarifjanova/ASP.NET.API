using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Contexts
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
    }
}
