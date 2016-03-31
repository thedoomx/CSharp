using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HackNumber
    {
        public static string IntToBinary(int n)
        {
            string word = "";
            while (n > 0)
            {
                int temp = n % 2;
                word = temp + word;

                n /= 2;
            }
            return word;
        }
        public static bool HackBinaryCheck(int n)
        {
            string word = "";
            while (n > 0)
            {
                int temp = n % 2;
                word = temp + word;

                n /= 2;
            }

            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals('1'))
                {
                    counter += 1;
                }
            }
            
            if (counter % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPalindrome(string n)
        {
            string number = n;
            string newNumber = "";
            char[] chars = number.ToCharArray();
            Array.Reverse(chars);
            newNumber = new String(chars);

            if(newNumber.Equals(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsHack(int n)
        {
            if(IsPalindrome(IntToBinary(n)) == true && HackBinaryCheck(n) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void NextHack(int n)
        {
            int next = n + 1;

            while (true)
            {
                if (IsHack(next) == true)
                {
                    Console.WriteLine(next);
                    break;
                }
                else
                {
                    next += 1;
                }
            }
        }
    }
}
