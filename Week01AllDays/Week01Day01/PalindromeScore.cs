using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PalindromeScore
    {
        public static int PScore(int n, int tempScore = 0)
        {
            int score = tempScore;

            string number = n.ToString();

            if (HackNumber.IsPalindrome(number))
            {
                return score + 1;
            }
            else
            {
                score += 1;
                char[] arr = number.ToCharArray();
                Array.Reverse(arr);
                string newNumber = new String(arr);
                int sum = n + (Int32.Parse(newNumber));

                return PScore(sum, score);
            }
        }
    }
}
