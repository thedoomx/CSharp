using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day01
{
    public static class SearchAndSortExtensions
    {
        public static IList<T> BubbleSort<T>(this IList<T> arr, IComparer<T> compare)
        {
            while (true)
            {
                int swaps = 0;

                for (int i = 0; i < arr.Count - 1; i++)
                {

                    if (compare.Compare(arr[i], arr[i + 1]) == 1)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swaps++;
                    }
                }

                if (swaps == 0)
                {
                    break;
                }
            }

            return arr;
        }

        public static IList<T> BubbleSort<T>(this IList<T> list)
        {
            return list.BubbleSort(Comparer<T>.Default);
        }

        public static IList<T> SelectionSort<T>(this IList<T> list, IComparer<T> comparer)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                T min = list[i];
                int swapIndex = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer.Compare(min, list[j]) == 1)
                    {
                        min = list[j];
                        swapIndex = j;
                    }
                }

                T temp = list[i];
                list[i] = min;          
                list[swapIndex] = temp;
            }

            return list;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list)
        {
            return list.SelectionSort(Comparer<T>.Default);
        }
    }
}