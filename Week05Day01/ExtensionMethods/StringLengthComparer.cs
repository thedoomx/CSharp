using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day01
{
    class StringLengthComparer : IComparer<String>
    {
        public int Compare(string x, string y)
        {
            int xLength;
            int yLength;

            if (x == null)
            {
                xLength = 0;
            }
            else
            {
                xLength = x.Length;
            }

            if (y == null)
            {
                yLength = 0;
            }
            else
            {
                yLength = y.Length;
            }


            if (xLength > yLength)
            {
                return 1;
            }
            else if (xLength < yLength)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
