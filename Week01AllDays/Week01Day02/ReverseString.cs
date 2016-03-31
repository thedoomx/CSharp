using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ReverseString
    {
        public static string ReverseMe(string original)
        {
            string result = "";

            for (int i = 0; i < original.Length; i++)
            {
                result = original[i] + result;
            }

            return result;
        }

        public static string ReverseEveryWord(string a)
        {
            string temp = "";
            string separators = " ,.!?:-/'\"";
            string result = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (separators.Contains(a[i]))
                {
                    result += ReverseString.ReverseMe(temp);
                    result += a[i];

                    temp = "";
                }
                else
                {
                    temp += a[i];
                }
            }

            result += ReverseString.ReverseMe(temp);

            return result;
        }
    }
}
