using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Vowels
    {
        public static void CountVowels(string str)
        {
            string vowels = "aeiouy";
            str = str.ToLower();
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
