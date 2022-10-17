using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Offering
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ServiceOptions { get; set; }
        public int EWT { get; set; } // EWT - Estimated Waiting Time (dine-in & takeaway)
        public int ETA { get; set; } // ETA - Estimated Time of Arrival (delivery)
        public string MealOfTheDay { get; set; }
        public string CourseOfMeal { get; set; }
        public string Cuisine { get; set; }
        // an offering can only belong to a restaurant
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        // an offering can be multiple customers' favorite
        public virtual ICollection<Customer> FavoringCustomers { get; set; }
        // an offering can be ordered by multiple customers
        public virtual ICollection<Customer> OrderingCustomers { get; set; }
    }
}
