using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DecodeURL
    {
        public static string DecodeUrl(string url)
        {
            string result = "";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("%20", " ");
            dict.Add("%3A", ":");
            dict.Add("%3D", "?");
            dict.Add("%2F", "/");
            
            string temp = "";

            for (int i = 0; i < url.Length - 2; i++)
            {
                if (url[i] == '%')
                {
                    temp += "" + url[i] + url[i + 1] + url[i + 2];

                    i += 2;

                    result += dict[temp];
                    temp = "";
                }
                else
                {
                    result += url[i];
                }

            }

            return result;
        }
    }
}
