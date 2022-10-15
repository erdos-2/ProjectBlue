using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; } // should uniquely identify a user
        public string AccountType { get; set; }
        public string EmailType { get; set; }
        public string Password { get; set; }
        public List<Restaurant> FavoriteRestaurants { get; set; }
        public List<Offering> FavoriteOfferings { get; set; }
        public List<Offering> CurrentOrders { get; set; }
        public List<Offering> PastOrders { get; set; }
    }
}
