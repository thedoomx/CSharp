using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CharHistogram
    {
        public static void MakeHistogram(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c] += 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in dict)
            {
                Console.Write(kvp.Key + ":" + kvp.Value + " // ");
            }
        }
    }
}
