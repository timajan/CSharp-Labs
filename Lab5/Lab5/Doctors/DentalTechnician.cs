using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class DentalTechnician : Dentist
    {
        public List<DentalService> OfferedServices { get; set; }
        public List<string> TechniquesMastered { get; set; }
        public DentalTechnician(string name, double salary, int yearsOfExperience, List<string> materialUsed) : base(name, salary, yearsOfExperience, materialUsed)
        {
            TechniquesMastered = new List<string>();
            OfferedServices = new List<DentalService>();
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Dental Technician {Name}, Salary: {Salary}, Years of Experience: {YearsOfExperience}, " +
                $"Techniques: {string.Join(", ", TechniquesMastered)}, Material used: {string.Join(", ", MaterialUsed)}");
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
