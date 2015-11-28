using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTimeTasks.UnfortunateFridays(1993, 1999));
            //DateTimeTasks.PrintDateWithGivenSum(1993, 25);
            //DateTimeTasks.HackerTime();

            //DateTime first = new DateTime(2000, 01, 10, 10, 20, 00);
            //DateTime second = new DateTime(2000, 01, 10, 11, 00, 00);
            //DateTime third = new DateTime(2000, 01, 10, 10, 45, 00);
            //
            //TimeSpan firstDuration = new TimeSpan(01, 10, 00);
            //TimeSpan secondDuration = new TimeSpan(00, 45, 00);
            //TimeSpan thirdDuration = new TimeSpan(01, 00, 00);
            //
            //DateTime[] appointments = new DateTime[] { first, second, third };
            //TimeSpan[] durations = new TimeSpan[] { firstDuration, secondDuration, thirdDuration };
            //
            //DateTimeTasks.FindIntersectingAppointments(appointments, durations);

            //DateTimeTasks.PrintCalendar(04, 2015, new System.Globalization.CultureInfo("bg-BG"));
            DateTimeTasks.BankAccountBalance("TextFile1.txt");

        }
    }
}
