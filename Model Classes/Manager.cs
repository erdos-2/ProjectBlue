using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Manager
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string AccountType { get; set; }
        public string EmailType { get; set; }
        public string Password { get; set; }
        // a manager can own multiple restaurants
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
