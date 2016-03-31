using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ExtremeElements
    {
        public static int Min(int[] items)
        {
            int min = items[0];

            foreach (var item in items)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static int Max(int[] items)
        {
            int max = items[0];

            foreach (var item in items) 
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static int NthMin(int n, int[] items)
        {
            List<int> container = items.ToList();
            while (n > 1)
            {
                container.Remove(ExtremeElements.Min(items));
                

                items = container.ToArray();
                n--;
            }

            return ExtremeElements.Min(items);
        }

        public static int NthMax(int n, int[] items)
        {
            List<int> container = items.ToList();

            while (n > 1)
            {
                container.Remove(ExtremeElements.Max(items));

                items = container.ToArray();

                n--;
            }

            return ExtremeElements.Max(items);
        }
    }
}
