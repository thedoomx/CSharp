using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day01
{
    class LastDigitComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int xLastDigit = x % 10;
            int yLastDigit = y % 10;

            if (xLastDigit > yLastDigit)
            {
                return 1;
            }
            else if (xLastDigit < yLastDigit)
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
