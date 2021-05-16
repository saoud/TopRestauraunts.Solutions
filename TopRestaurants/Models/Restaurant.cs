namespace TopRestaurants.Models
{

  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int PriceRange { get; set; }
    public string Location { get; set; }

    // public int CuisineId { get; set; }
    // public virtual Cuisine Cuisine { get; set; }

  }
}