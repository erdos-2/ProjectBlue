using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    internal class Offering
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Restaurant Restaurant { get; set; }
        public int EWT { get; set; } // EWT - Estimated Waiting Time (dine-in & takeaway)
        public int ETA { get; set; } // ETA - Estimated Time of Arrival (delivery)

    }
}
