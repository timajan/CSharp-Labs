using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class Surgeon : Doctor
    {
        public bool IsBoardCertified { get; private set; }

        public Surgeon(string name, double salary, int yearsOfExperience, bool isBoardCertified) : base(name, salary, yearsOfExperience)
        {
            IsBoardCertified = isBoardCertified;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Surgeon {Name}, Salary: {Salary}, Years of Experience: {YearsOfExperience}, Does have a certificate: {IsBoardCertified}");
        }
    }
}
