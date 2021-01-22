using Microsoft.EntityFrameworkCore;

namespace ParkIt.Models
{
  public class ParkItContext : DbContext
  {
    public ParkItContext(DbContextOptions<ParkItContext> options)
      :base(options)
    {
    }

    public DbSet<Park> Parks {get;set;}
  }
}