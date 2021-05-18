using System.Collections.Generic;

namespace TopRestaurants.Models
{
    public class Cuisine
    {
        public Cuisine() //when does this get called?
        {
            this.Restaurants = new HashSet<Restaurant>();
        }

        public int CuisineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}