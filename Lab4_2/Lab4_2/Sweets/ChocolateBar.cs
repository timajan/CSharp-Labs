using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Sweets
{
    public class ChocolateBar : Sweet
    {
        public string ChocolateType { get; set; } // E.g., Milk, Dark

        public ChocolateBar(string name, double weight, double sugarContent, string chocolateType)
            : base(name, weight, sugarContent)
        {
            ChocolateType = chocolateType;
        }
    }
}
