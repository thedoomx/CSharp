using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Factorial
    {
        public static int GetFactiorialLoopStyle(int n)
        {
            int result = 1;

            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                return result;
            }
        }

        public static int GetFactorialRecursionStyle(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * GetFactorialRecursionStyle(n - 1);
            }
        }
    }
}
