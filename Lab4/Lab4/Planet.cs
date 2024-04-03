using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public class Continent
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxHeight { get; set; }

        public override string ToString()
        {
            return $"{Name}. Area: {Area}. Max height: {MaxHeight}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Continent continent)
            {
                return Name == continent.Name && Area == continent.Area && MaxHeight == continent.MaxHeight;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Island
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxHeight { get; set; }
        public bool IsCountry { get; set; }
        public override string ToString()
        {
            return $"{Name}. Is country: {IsCountry}. Area: {Area}. Max height: {MaxHeight}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Island island)
            {
                return Name == island.Name && Area == island.Area && MaxHeight == island.MaxHeight && IsCountry == island.IsCountry;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Ocean
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxDeep { get; set; }
        public override string ToString()
        {
            return $"{Name}. Area: {Area}. Max deep: {MaxDeep}";
        }

    }

    public class Planet
    {
        public string Name { get; set; }
        public int Radius { get; set; }
        public List<Continent> Continents { get; set; }
        public List<Island> Islands { get; set; }
        public List<Ocean> Oceans { get; set; }

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
            foreach (var continent in Continents)
            {
                Console.Write(continent.Name + "  ");
            }
            Console.WriteLine();
        }
        public void PrintCountContinents()
        {
            Console.WriteLine(Continents.Count);
        }
    }
}
