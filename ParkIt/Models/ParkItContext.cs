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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park {ParkId=1, Name="Crater Lake", State="Oregon", ParkType="National"},
          new Park {ParkId=2, Name="Grand Canyon", State="Arizona", ParkType="National"},
          new Park {ParkId=3, Name="Yosemite", State="California", ParkType="National"},
          new Park {ParkId=4, Name="Redwood", State="California", ParkType="National"},
          new Park {ParkId=5, Name="Silver Falls", State="Oregon", ParkType="State"},
          new Park {ParkId=6, Name="Fort Stevens", State="Oregon", ParkType="State"}
        );
    }
  }
}