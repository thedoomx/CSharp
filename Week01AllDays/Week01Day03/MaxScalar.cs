using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MaxScalar
    {
        public static int MaxScalarProduct(List<int> v1, List<int> v2)
        {
            int max = 0;
            v1.Sort();
            v2.Sort();


            for (int i = 0; i < v1.Count; i++)
            {
                max += v1[i] * v2[i];
            }

            return max;
        }
    }
}
