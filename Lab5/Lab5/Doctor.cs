using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Doctor
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int YearsOfExperience { get; set; }

        protected Doctor(string name, double salary, int yearsOfExperience)
        {
            Name = name;
            Salary = salary;
            YearsOfExperience = yearsOfExperience;
        }

        public abstract void DisplayInfo();
    }
}
