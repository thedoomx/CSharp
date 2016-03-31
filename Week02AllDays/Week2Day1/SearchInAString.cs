using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class SearchInAString
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Contains(searched))
                {
                    foundIndex = i;
                    return true;
                }
            }
            foundIndex = -1;
            return false;
        }
    }
}
