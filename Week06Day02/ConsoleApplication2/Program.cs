using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filters;
using Events;

namespace ConsoleApplication2
{
    public delegate bool FilterDelegate(int number);

    class Program
    {
        static void Main(string[] args)
        {
            //Filter fil = new Filter();
            //List<int> numbers = new List<int>() { 1, 5, 2, 123, 12, 122 };
            //List<int> filtered = fil.FilterCollection(numbers, fil.FilterBiggerThanTen);

            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);
            //}

            //Aggregates agg = new Aggregates();
            //List<int> numbers = new List<int>() { 1, 5, 2, 123, 12, 122 };
            //int sum = agg.AggregateCollection(numbers, agg.SumItems);

            //Console.WriteLine(sum);


            //AverageAggregator aA = new AverageAggregator();
            //int number = 5;
            //aA.AverageChanged += (s, e) => Console.WriteLine("Average has changed " + (s as AverageAggregator).Average);
            //aA.AddNumber(number);
            //aA.AddNumber(123);
            //aA.AddNumber(64);

            List<Student> list = new List<Student>();
            Student a = new Student();
            a.hasDog = false;
            Student b = new Student();
            b.studentId = 1;
            Student c = new Student();
            c.studentName = "ivo";

            
        }

        

        private static void AA_AverageChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Average has changed" + (sender as AverageAggregator).Average);
        }
    }
}
