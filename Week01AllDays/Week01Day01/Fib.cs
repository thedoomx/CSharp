using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fib
    {
        public static void FibNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(Fibonacci(i));
            }
            Console.WriteLine();
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 2 || n == 1)
            {
                return 1;
            }
            else
            {
                int first = 1;
                int second = 1;
                int next = 0;

                for (int i = 3; i <= n; i++)
                {
                    next = first + second;
                    first = second;
                    second = next;
                }

                return next;
            }
        }
    }
}
