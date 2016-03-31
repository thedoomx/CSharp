using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ListTasks
    {
        public static List<int> NumberToList(int n)
        {
            List<int> result = new List<int>();

            while(n > 0)
            {
                int digit = n % 10;
                result.Add(digit);

                n /= 10;
            }

            return result;
        }

        public static int ListToNumber(List<int> numbers)
        {
            int result = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in numbers)
            {
                sb.Append(item);
            }

            result = int.Parse(sb.ToString());

            return result;
        }
    }
}
