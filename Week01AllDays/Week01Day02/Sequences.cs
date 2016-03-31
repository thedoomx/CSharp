using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Sequences
    {
        public static bool IsIncreasing(int[] sequence)
        {
            int max = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > max)
                {
                    max = sequence[i];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            int max = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                if(sequence[i] < max)
                {
                    max = sequence[i];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
