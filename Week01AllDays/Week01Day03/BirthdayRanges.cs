using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BirthdayRanges
    {
        public static List<int> BirthdayRange(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < ranges.Count; i++)
            {
                result.Add(0);
            }

            for (int i = 0; i < ranges.Count; i++)
            {
                for (int j = 0; j < birthdays.Count; j++)
                {
                    if((birthdays[j] >= ranges[i].Key) && (birthdays[j] <= ranges[i].Value))
                    {
                        result[i]++;
                    }
                }
            }

            return result;
        }
    }
}
