using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Anagram
    {
        public static bool IsAnagram(string a, string b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }
            else
            {
                List<char> list = new List<char>();
                list = b.ToList();

                for (int i = 0; i < a.Length; i++)
                {
                    if (list.Contains(a[i]))
                    {
                        list.Remove(a[i]);
                    }
                }

                if (list.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public static bool HasAnagramOf(string a, string b)
        {
            List<char> list = a.ToList();

            for (int i = 0; i < b.Length - a.Length + 1; i++)
            {
                if(list.Contains(b[i]))
                {
                    string temp = b[i].ToString();
                    int index = i + 1;

                    while (temp.Length < a.Length)
                    {
                        temp += b[index].ToString();
                        index += 1;
                    }
                    
                    if (Anagram.IsAnagram(temp, a))
                    {
                        Console.WriteLine("Good job, there is an anagram of a in b: " + a + " - " + temp);
                        return true;
                    }
                }
            }

            Console.WriteLine("No anagrams of a in b are found!");
            return false;
        }
    }
}
