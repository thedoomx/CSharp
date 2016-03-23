using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class ArrayExtension 
    {
        public static List<T> Intersect<T>(this List<T> firstList, List<T> secondList)
        {
            List<T> result = new List<T>();

            foreach (T item in secondList)
            {
                if(firstList.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static List<T> UnionAll<T>(List<T> firstList, List<T> secondList)
        {
            List<T> result = new List<T>();

            result = firstList;

            foreach (var item in secondList)
            {
                result.Add(item);
            }

            return result;
        }

        public static List<T> Union<T>(List<T> firstList, List<T> secondList)
        {
            List<T> result = new List<T>();

            foreach (var item in firstList)
            {
                if(!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            foreach (var item in secondList) 
            {
                if(!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static string Join(List<string> list)
        {
            string result = "";

            foreach (string item in list)
            {
                result += item;
                result += Configuration.GetReplacingValue();
            }

            return result;
        }

        private class Configuration
        {
            public static char GetReplacingValue()
            {
                string date = DateTime.Now.ToString();
                string digits = "0123456789";
                int sum = 0;

                for (int i = 0; i < date.Length; i++)
                {
                    if (digits.Contains(date[i]))
                    {
                        int temp;
                        int.TryParse(date[i].ToString(), out temp);
                        sum += temp;
                    }
                }

                sum = 45 % sum;
                sum += 65;

                return (char)sum;
            }
        }
    }
}
