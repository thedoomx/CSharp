using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IntegerPalindromes
    {
        public static bool IsIntPalindrome(int n)
        {
            int a = n;
            int b = 0;

            while (a > 0)
            {
                int digit = a % 10;
                b = (b * 10) + digit;

                a /= 10;
            }
            
            if (n == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetLargestPalindrome(int n)
        {
            if (IntegerPalindromes.IsIntPalindrome(n))
            {
                return n;
            }
            else
            {
                while (true)
                {
                    n--;
                    if (IntegerPalindromes.IsIntPalindrome(n))
                    {
                        return n;
                        break;
                    }
                }
            }
        }
    }
}
