using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        //private static object lockObj = new object();
        //private static object lockObj2 = new object();

        static void Main(string[] args)
        {
            //var thread = new Thread(Write1);
            //thread.Start();
            //Thread.Sleep(1000);

            //Write2();

            DateTime now = DateTime.Now;

            Thread.Sleep(10000);

            DateTime later = DateTime.Now;

            TimeSpan ts = later - now;
            double mins = (double)ts.TotalMinutes;

            Console.WriteLine(mins);
        }

        //private static void Write1()
        //{
        //    lock(lockObj)
        //    {
        //        Console.WriteLine("Write1 start");
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Write1 end");
        //        //for (int i = 0; i < 10000000; i++)
        //        //{
        //        //    Console.Write("a");
        //        //    Thread.Sleep(1000);
        //        //}
        //    }
            
        //}

        //private static void Write2()
        //{
        //    lock(lockObj2)
        //    {
        //        for (int i = 0; i < 10000000; i++)
        //        {
        //            Console.Write("b");
        //            Thread.Sleep(1300);
        //        }
        //    }
            
        //}
    }
}
