using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class FactorialGenerator
    {
        public static IEnumerable<int> GenerateFactorials(int n)
        {
            //5 * 4* 3* 2* 1
            int result = 1;
            for (int i = n; i > 1; i--)
            {
                yield return result *= i;
            }
        }
    }
}
