using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class JoiningStrings
    {
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder result = new StringBuilder();
            result.Append(strings[0]);
            for (int i = 1; i < strings.Length; i++)
            {
                result.Append(separator);
                result.Append(strings[i]);
            }

            return result.ToString();
        }
    }
}
