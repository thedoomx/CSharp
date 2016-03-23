using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    public delegate int AggregationDelegate(int currentResult, int n);

    public class Aggregates
    {
        public Aggregates()
        {
            
        }

        public int SumItems(int currentResult, int n)
        {
            return currentResult + n;
        }

        public int AggregateCollection(List<int> original, AggregationDelegate aggregate)
        {
            int result = 0;

            foreach (var item in original)
            {
                result = SumItems(result, item);
            }

            return result;
        }
    }
}
