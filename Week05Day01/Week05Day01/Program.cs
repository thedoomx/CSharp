using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day01
{
    class Program 
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 2, 3, 102, 123, 1, 5 };

            //int[] arrSorted = (int[])arr.SelectionSort(new LastDigitComparer());

            //foreach(int item in arrSorted) {
            //    Console.WriteLine(item);
            //}

            IList<string> list = new List<string>() { "asd", "aadsd", null };
            IList<string> sorted = list.BubbleSort(new StringLengthComparer());

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }


        }
    }
}
