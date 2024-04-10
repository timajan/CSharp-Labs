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

        public Continent(string name, int area, int max_height)
        {
            Name = name;
            Area = area;
            MaxHeight = max_height;
        }

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
}
