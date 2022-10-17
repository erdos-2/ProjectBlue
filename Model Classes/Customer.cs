using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; } // should uniquely identify a user
        public string AccountType { get; set; }
        public string EmailType { get; set; }
        public string Password { get; set; }
        // a customer can have multiple favorite offerings
        public virtual ICollection<Offering> FavoriteOfferings { get; set; }
        // a customer can have multiple favorite restaurants
        public virtual ICollection<Restaurant> FavoriteRestaurants { get; set; }
        // a customer can have multiple offering orders
        public virtual ICollection<Offering> OrderedOfferings { get; set; }
    }
}
