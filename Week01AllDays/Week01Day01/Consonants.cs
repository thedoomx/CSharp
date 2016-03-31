using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Consonants
    {
        public static void CountConsonants(string str)
        {
            str = str.ToLower();
            int counter = 0;
            string consonants = "bcdfghjklmnpqrstvwxz";

            for (int i = 0; i < str.Length; i++)
            {
                if (consonants.Contains(str[i]))
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
