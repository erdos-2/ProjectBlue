using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Restaurant
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceOptions { get; set; }
        public string WorkingHours { get; set; }
        // a restaurant can only be owned by a manager
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        // a restaurant can have multiple offerings
        public ICollection<Offering> Offerings { get; set; }
        // a restaurant can be multiple customers' favorite
        public virtual ICollection<Customer> FavoringCustomers { get; set; }
    }
}
