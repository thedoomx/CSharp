using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    public delegate bool FilterDelegate(int number);
    
    public class Filter
    {
        public Filter()
        {

        }

        public bool FilterEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public bool FilterBiggerThanTen(int a)
        {
            if (a > 10)
            {
                return true;
            }

            return false;
        }

        public List<int> FilterCollection(List<int> numbers, FilterDelegate filter)
        {
            List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (filter(item) == true)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
