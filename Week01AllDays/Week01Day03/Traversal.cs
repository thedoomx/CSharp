using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Traversal
    {
        public static bool IsTraversal(List<int> traversal, List<List<int>> family)
        {
            for (int i = 0; i < family.Count; i++)
            {
                string temp = ListToWord(family[i]);
                int occurence = 0;
                foreach (var item in traversal)
                {
                    if (temp.Contains(item.ToString()))
                    {
                        occurence++;
                    }
                }

                if(occurence == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static string ListToWord(List<int> traversal)
        {
            string word = "";
            foreach (var item in traversal)
            {
                word += item;
            }

            return word;
        }
    }
}
