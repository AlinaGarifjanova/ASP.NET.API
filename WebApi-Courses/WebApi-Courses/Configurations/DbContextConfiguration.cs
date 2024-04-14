using Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Courses.Configurations
{
    public static class DbContextConfiguration
    {
        public static void RegisterDbContext (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApiContext>(x => x.UseSqlServer(config.GetConnectionString("SqlServer")));
        }
    }
}
