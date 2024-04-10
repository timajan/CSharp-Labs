using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class PlasticSurgeon : Surgeon
    {
        public int ContinuingEducationCredits { get; set; }

        public PlasticSurgeon(string name, double salary, int yearsOfExperience, bool isBoardCertified, int continuingEducationCredits) : base(name, salary, yearsOfExperience, isBoardCertified)
        {
            ContinuingEducationCredits = continuingEducationCredits;
        }
    }
}
