using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Sweets
{
    public class Lollipop : Sweet
    {
        public bool IsSugarFree { get; set; }

        public Lollipop(string name, double weight, double sugarContent, bool isSugarFree)
            : base(name, weight, sugarContent)
        {
            IsSugarFree = isSugarFree;
        }
    }
}
