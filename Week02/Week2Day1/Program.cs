using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //ReverseList.ReverseIntList(ref numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Rectangle rect = new Rectangle(0, 0, 10, 10);
            //Size size = new Size(2, 2);
            //InflateARectangle.Inflate(ref rect, size);
            //Console.WriteLine(rect);

            //List<string> words = new List<string>() { "ist", "listen", "blalasd0", "arlist" };
            //int foundIndex = 10;
            //SearchInAString.TryFindSubstring(words, "list", out foundIndex);
            //Console.WriteLine(foundIndex);

            //Console.WriteLine(JoiningStrings.JoinStrings("123", "bla", "bla", "bla"));

            //foreach (var item in FactorialGenerator.GenerateFactorials(5))
            //{
            //    Console.WriteLine(item);
            //}

            foreach(string name in DirectoryTraversal.IterateDirectory(new DirectoryInfo(@"D:\Movies\")))
            {
                Console.WriteLine(name);
            }
        }

        

       
    }
}
