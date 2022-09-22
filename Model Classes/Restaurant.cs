using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    internal class Restaurant
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhoneNo { get; set; }
        public string ServiceOptions { get; set; }
        public string WorkingHours { get; set; }
        public Offering[] Offerings { get; set; }
    }
}
