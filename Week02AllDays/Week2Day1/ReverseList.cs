using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class ReverseList
    {
        
        public static void ReverseIntList(ref List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result.Add(numbers[i]);
            }
            
            numbers = result;
        }
    }
}
