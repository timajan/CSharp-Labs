using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class Dentist : Doctor
    {
        public List<DentalService> OfferedServices { get; set; }
        public List<string> MaterialUsed { get; set; }
        public Dentist(string name, double salary, int yearsOfExperience, List<string> materialUsed) : base(name, salary, yearsOfExperience)
        {
            MaterialUsed = materialUsed;
            OfferedServices = new List<DentalService>();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Dentist {Name}, Salary: {Salary}, Years of Experience: {YearsOfExperience}");
        }

        public void AddService(DentalService service)
        {
            OfferedServices.Add(service);
        }

        // Calculate the total payment for a list of services provided to a client
        public double CalculatePayment(List<DentalService> servicesProvided)
        {
            double totalPayment = 0;
            foreach (var service in servicesProvided)
            {
                // Here, we could also apply discounts, insurance adjustments, or other factors
                totalPayment += service.BaseCost;
            }
            return totalPayment;
        }
    }
}
