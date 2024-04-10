using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Doctors
{
    public class Neurosurgeon : Surgeon
    {
        public string ArtisticSkillsLevel { get; set; } // Could be "High", "Medium", "Low"

        public Neurosurgeon(string name, double salary, int yearsOfExperience, bool isBoardCertified, string artisticSkillsLevel) : base(name, salary, yearsOfExperience, isBoardCertified)
        {
            ArtisticSkillsLevel = artisticSkillsLevel;
        }
    }
}
