using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class DateTimeTasks
    {
        public static int UnfortunateFridays(int startYear, int endYear)
        {
            int result = 0;

            DateTime start = new DateTime(startYear, 01, 01);
            DateTime end = new DateTime(endYear, 01, 01);

            while (start.Year < end.Year)
            {
                if (start.Day.Equals(13))
                {
                    if (start.DayOfWeek.ToString().Equals("Friday"))
                    {
                        result++;
                    }
                }

                start = start.AddDays(1);
            }

            return result;
        }

        public static void PrintDateWithGivenSum(int year, int sum)
        {
            //1993 + 02 + 01 == 25
            DateTime time = new DateTime(year, 01, 01);

            while (time.Year == year)
            {
                int digitsSum = 0;
                digitsSum += GetDigitsSum(time.Year) + GetDigitsSum(time.Day) + GetDigitsSum(time.Month);

                if (digitsSum == sum)
                {
                    Console.WriteLine(time.ToString("dd/MM/yyyy"));
                }

                time = time.AddDays(1);
            }
        }

        static int GetDigitsSum(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;

                n /= 10;
            }

            return sum;
        }

        public static void HackerTime()
        {
            DateTime now = DateTime.Now;
            DateTime hackerTime = new DateTime(now.Year, 12, 21, 13, 37, 00);
            TimeSpan difference = new TimeSpan();
            if (now < hackerTime)
            {
                difference = hackerTime - now;
            }
            else
            {
                hackerTime = hackerTime.AddYears(1);
                difference = hackerTime - now;
            }
            Console.WriteLine("{0:F0}:{1:F0}:{2:F0}", difference.TotalDays, difference.TotalHours, difference.TotalMinutes);
        }


        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            for (int i = 0; i < startDates.Length - 1; i++)
            {
                DateTime firstAppEnd = startDates[i].Add(durations[i]);
                for (int j = i + 1; j < startDates.Length; j++)
                {
                    DateTime secondAppEnd = startDates[j].Add(durations[j]);

                    if (startDates[i] <= startDates[j] && secondAppEnd >= firstAppEnd)
                    {
                        TimeSpan result = firstAppEnd - startDates[j];

                        Console.WriteLine("The appointment starting at " + startDates[i].ToString("dd/MM/yyyy hh:mm")
                            + " intersects with the appointment starting at " + startDates[j].ToString("dd/MM/yyyy hh:mm")
                            + " with exactly {0} minutes", result.TotalMinutes);
                    }
                    else if (startDates[i] <= startDates[j] && firstAppEnd >= secondAppEnd)
                    {
                        Console.WriteLine("{0}", durations[j].TotalMinutes);
                    }
                    else if (startDates[j] <= startDates[i] && secondAppEnd <= firstAppEnd)
                    {
                        Console.WriteLine("The appointment starting at " + startDates[i].ToString("dd/MM/yyyy hh:mm")
                            + " intersects with the appointment starting at " + startDates[j].ToString("dd/MM/yyyy")
                            + " with exactly {0} minutes", (secondAppEnd - startDates[i]).TotalMinutes);
                    }
                    else if (startDates[i] >= startDates[j] && firstAppEnd <= secondAppEnd)
                    {
                        Console.WriteLine("{0}", durations[i]);
                    }
                }
            }
        }

        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            DateTime date = new DateTime(year, month, 01);
            Console.WriteLine(date.ToString("MMMM", culture));

            string[] daysOfWeek = culture.DateTimeFormat.DayNames;
            for (int i = 1; i < daysOfWeek.Length; i++)
            {
                Console.Write(daysOfWeek[i] + " ");
            }
            Console.Write(daysOfWeek[0]);
            Console.WriteLine();

            string dayOne = date.DayOfWeek.ToString();
            DateTime endDate = date.AddMonths(1);

            if (dayOne.Equals("Tuesday"))
            {
                Console.Write(String.Format("0,18}", date.Day));
                date = date.AddDays(1);
            }
            else if (dayOne.Equals("Wednesday"))
            {
                Console.Write(String.Format("{0,24}", date.Day));
                date = date.AddDays(1);
            }
            else if (dayOne.Equals("Thursday"))
            {
                Console.Write(String.Format("{0,34}", date.Day));
                date = date.AddDays(1);
            }
            else if (dayOne.Equals("Friday"))
            {
                Console.Write(String.Format("{0,40}", date.Day));
                date = date.AddDays(1);
            }
            else if (dayOne.Equals("Saturday"))
            {
                Console.Write(String.Format("{0,47}", date.Day));
                date = date.AddDays(1);
            }
            else if (dayOne.Equals("Sunday"))
            {
                Console.WriteLine(String.Format("{0,54}", date.Day));
                date = date.AddDays(1);
            }
            else
            {
                Console.Write(String.Format("{0,10}", date.Day));
                date = date.AddDays(1);
            }

            while (date < endDate)
            {
                if (date.DayOfWeek.ToString().Equals("Monday"))
                {
                    Console.Write(String.Format("{0,10}", date.Day));
                }
                else if (date.DayOfWeek.ToString().Equals("Tuesday"))
                {
                    Console.Write(String.Format("{0,8}", date.Day));
                }
                else if (date.DayOfWeek.ToString().Equals("Wednesday"))
                {
                    Console.Write(String.Format("{0,6}", date.Day));
                }
                else if (date.DayOfWeek.ToString().Equals("Thursday"))
                {
                    Console.Write(String.Format("{0,10}", date.Day));
                }
                else if (date.DayOfWeek.ToString().Equals("Friday"))
                {
                    Console.Write(String.Format("{0,6}", date.Day));
                }
                else if (date.DayOfWeek.ToString().Equals("Saturday"))
                {
                    Console.Write(String.Format("{0,7}", date.Day));
                }
                else
                {
                    Console.WriteLine(String.Format("{0,7}", date.Day));
                }

                date = date.AddDays(1);
            }
            Console.WriteLine();

        }

        public static void BankAccountBalance(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] split = new string[] { ";" };
            string inputOperation = "внасяне";
            string outputOperation = "теглене";
            Dictionary<DateTime, Decimal> container = new Dictionary<DateTime, decimal>();

            IFormatProvider culture = new System.Globalization.CultureInfo("bg-BG", true);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] operations = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                string date = operations[0];
                DateTime tempDate = Convert.ToDateTime(date, culture);
                Decimal money = 0;
                string tempMoney = operations[2];
                StringBuilder temp = new StringBuilder();

                for (int i = 0; i < tempMoney.Length - 2; i++)
                {
                    temp.Append(tempMoney[i]);
                }

                money = Decimal.Parse(temp.ToString());

                if (operations[1].Equals(outputOperation)) money -= (money * 2);


                if (container.ContainsKey(tempDate))
                {
                    container[tempDate] += money;
                }
                else
                {
                    container.Add(tempDate, money);
                }
            }

            foreach (KeyValuePair<DateTime, Decimal> item in container) 
            {
                Console.WriteLine(item.Key.ToString("dd/MM/yyyy", culture) + " : " + item.Value.ToString(culture));
            }
        }
    }
}
