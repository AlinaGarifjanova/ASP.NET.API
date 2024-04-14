using Microsoft.EntityFrameworkCore;
using WebApi_subscriber.Entities;

namespace WebApi_subscriber.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
   public DbSet<SubscribeEntity> Subscribers { get; set; }

}
