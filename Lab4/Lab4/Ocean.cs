using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Ocean
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxDeep { get; set; }

        public Ocean(string name, int area, int max_deep)
        {
            Name = name;
            Area = area;
            MaxDeep = max_deep;
        }

        public override string ToString()
        {
            return $"{Name}. Area: {Area}. Max deep: {MaxDeep}";
        }

    }
}
