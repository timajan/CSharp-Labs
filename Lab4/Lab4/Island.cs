using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Island
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxHeight { get; set; }
        public bool IsCountry { get; set; }

        public Island(string name, int area, int max_height, bool is_country)
        {
            Name = name;
            Area = area;
            MaxHeight = max_height;
            IsCountry = is_country;
        }
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
}
