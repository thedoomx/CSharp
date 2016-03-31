using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lucas
    {
        public static int NthLucas(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int first = 2;
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

        public static void FirstNLucas(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(NthLucas(i) + " ");
            }

            Console.WriteLine();
        }
    }
}
