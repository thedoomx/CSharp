using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 1, 1, 2, 3, 4 };
            //List<int> numbers2 = new List<int>() { 4, 5, 3 };

            //List<int> result = numbers.Intersect(numbers2);

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine(ArrayExtension.Join(new List<string>() { "aaa", "bbb", "ccc" }));

            List<Book> books = new List<Book>() { new Book("Gosho", 1), new Book("Petko", 2) };
            List<Magazine> magazines = new List<Magazine>() { new Magazine("Gosho", 2), new Magazine("Tisho", 4)};

            List<string> sorted = MagazineAndBooksSorter.Sort(books, magazines);

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
           }
    }
}
