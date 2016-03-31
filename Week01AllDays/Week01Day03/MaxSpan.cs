using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MaxSpan
    {
        public static int Maxspan(List<int> numbers)
        {
            int maxSpan = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter = j;
                    }
                }

                if(maxSpan < (counter - i) + 1 )
                {
                    maxSpan = (counter - i) + 1;
                }
            }
            
            return maxSpan;
        }
    }
}
