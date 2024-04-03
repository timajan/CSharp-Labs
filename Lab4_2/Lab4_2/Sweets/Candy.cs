using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Sweets
{
    public class Candy : Sweet
    {
        public string Type { get; set; } // E.g., Chocolate, Gummy

        public Candy(string name, double weight, double sugarContent, string type)
            : base(name, weight, sugarContent)
        {
            Type = type;
        }
    }
}
