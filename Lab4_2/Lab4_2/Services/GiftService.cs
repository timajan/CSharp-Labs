using Lab4_2.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.Services
{
    public class GiftService
    {
        private readonly List<Sweet> sweets;

        public GiftService()
        {
            sweets = new List<Sweet>();
        }

        public void AddSweet(Sweet sweet)
        {
            sweets.Add(sweet);
        }
            
        public double CalculateTotalWeight()
        {
            return sweets.Sum(sweet => sweet.Weight);
        }

        public IEnumerable<Sweet> SortSweetsByWeight()
        {
            return sweets.OrderBy(sweet => sweet.Weight);
        }

        public IEnumerable<Sweet> FindSweetsBySugarContent(double min, double max)
        {
            return sweets.Where(sweet => sweet.SugarContent >= min && sweet.SugarContent <= max);
        }
    }
}
