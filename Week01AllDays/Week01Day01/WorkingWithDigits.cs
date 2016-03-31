using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WorkingWithDigits
    {
        public static void CountDigits(int n)
        {
            int counter = 0;
            while (n > 0)
            {
                n = n / 10;
                counter++;
            }

            Console.WriteLine(counter);
        }

        public static int SumDigits(int n)
        {
            int sum = 0;

            while(n > 0)
            {
                int digit = n % 10;
                sum += digit;

                n /= 10;
            }

            return sum;
        }

        public static void FactorialDigitsN(int n)
        {
            int sum = 0;
            
            while(n > 0)
            {
                int digit = n % 10;
                sum += Factorial.GetFactiorialLoopStyle(digit);

                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
