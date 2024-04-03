using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Sweets
{
    public class Marshmallow : Sweet
    {
        public string Flavor { get; set; } // E.g., Vanilla, Strawberry

        public Marshmallow(string name, double weight, double sugarContent, string flavor)
            : base(name, weight, sugarContent)
        {
            Flavor = flavor;
        }
    }
}
