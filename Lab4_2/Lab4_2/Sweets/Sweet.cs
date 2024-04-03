using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Sweets
{
    public abstract class Sweet
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double SugarContent { get; set; }

        protected Sweet(string name, double weight, double sugarContent)
        {
            Name = name;
            Weight = weight;
            SugarContent = sugarContent;
        }
    }
}
