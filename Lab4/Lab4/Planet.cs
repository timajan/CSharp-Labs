using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Planet
    {
        public string Name { get; set; }
        public int Radius { get; set; }
        public List<Continent> Continents { get; set; }
        public List<Island> Islands { get; set; }
        public List<Ocean> Oceans { get; set; }

        public Planet(string name, int radius, List<Continent> continents, List<Ocean> oceans, List<Island> islands)
        {
            Name = name;
            Radius = radius;
            Continents = continents;
            Oceans = oceans;
            Islands = islands;
        }

        public override string ToString()
        {
            string continents = string.Join(", ", Continents.Select(x => x.Name));
            string islands = string.Join(", ", Islands.Select(x => x.Name));
            string oceans = string.Join(", ", Oceans.Select(x => x.Name));

            return $"{Name}. Radius: {Radius}.\nContinents: {continents}.\nIslands: {islands}.\nOceans: {oceans}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Planet planet)
            {
                return Name == planet.Name && Radius == planet.Radius && Continents == planet.Continents && Islands == planet.Islands && Oceans == planet.Oceans;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void PrintPlanet()
        {
            Console.WriteLine(Name);
        }
        public void PrintContinent()
        {
            Console.WriteLine(string.Join(", ", Continents.Select(x => x.Name)));
        }
        public void PrintCountContinents()
        {
            Console.WriteLine("Count of continents: " + Continents.Count);
        }
    }
}
