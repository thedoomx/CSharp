using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class CopyChar
    {
        public static string CopyEveryChar(string input, int k)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    result += input[i];
                }
            }

            return result;
        }
    }
}
