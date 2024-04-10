using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class DentalService
    {
        public string ServiceType { get; set; }
        public double BaseCost { get; set; }

        public DentalService(string serviceType, double baseCost)
        {
            ServiceType = serviceType;
            BaseCost = baseCost;
        }
    }
}
