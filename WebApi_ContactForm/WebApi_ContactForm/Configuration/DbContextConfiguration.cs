using Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApi_ContactForm.Configuration
{
    public static class DbContextConfiguration
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApiContext>(x => x.UseSqlServer(config.GetConnectionString("SqlServer")));
        }
    }
}
