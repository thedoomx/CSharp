using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrimeNumbers
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void ListFirstPrimes(int n)
        {
            int counter = 0;
            int start = 2;
            List<int> primeList = new List<int>();

            while (counter < n)
            {
                if (PrimeNumbers.IsPrime(start))
                {
                    counter += 1;
                    primeList.Add(start);
                }

                start++;
            }

            foreach (var item in primeList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static void SieveOfEratosthenes(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("2");
            }
            else if (n == 2)
            {
                Console.WriteLine("2, 3");
            }
            else if (n == 3)
            {
                Console.WriteLine("2, 3, 5");
            }
            else
            {
                int counter = 3;
                int number = 6;
                List<int> primes = new List<int>();
                primes.Add(2);
                primes.Add(3);
                primes.Add(5);

                while (counter < n)
                {
                    if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0)
                    {
                        counter++;
                        primes.Add(number);
                    }

                    number++;
                }

                foreach (int item in primes)
                {
                    Console.Write(item + ", ");
                }
            }
        }

    }
}
