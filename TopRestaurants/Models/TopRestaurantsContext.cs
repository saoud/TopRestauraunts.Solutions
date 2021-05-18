using Microsoft.EntityFrameworkCore;

namespace TopRestaurants.Models
{

  public class TopRestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }

    public DbSet<Restaurant> Restaurants { get; set; }

    public TopRestaurantsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}