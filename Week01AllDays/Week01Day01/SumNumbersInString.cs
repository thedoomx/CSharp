using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SumNumbersInString
    {
        public static int SumOfNumbersInString(string str)
        {
            int result = 0;
            string digits = "0123456789";
            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (digits.Contains(str[i]))
                {
                    temp += str[i];
                }
                else
                {
                    if(!temp.Equals(""))
                    {
                        result += Int32.Parse(temp);
                        temp = "";
                    }
                }
            }

            if (!temp.Equals(""))
            {
                result += Int32.Parse(temp);
            }

            return result;
        }
    }
}
