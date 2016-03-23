using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Schedule
    {
        public int ID { get; set; }
        public string StartingCity { get; set; }
        public string EndCity { get; set; }
        public TimeSpan TravelTime { get; set; }
        public int TrainID { get; set; }
        public decimal TicketPrice { get; set; }

        public virtual List<City> City { get; set; }

        public Schedule()
        {
            City = new List<City>();
        }

        public static void DisplaySchedule(int id)
        {
            using (var context = new TicketsDB())
            {
                var schedule = (from s in context.Schedule
                                where s.ID == id
                                select s).FirstOrDefault();
                if (schedule != null)
                {
                    Console.WriteLine(string.Format("From: {0} to {1}, for {2}. Ticket price: {3}.",
                schedule.StartingCity, schedule.EndCity, schedule.TravelTime, schedule.TicketPrice));
                } 
                else
                {
                    Console.WriteLine("There isn't any schedule with that id");
                }
            }
        }

        public static void AddTrip(int trainID, string startingCity, string endCity, TimeSpan travelTime, decimal ticketPrice)
        {
            using (var context = new TicketsDB())
            {
                var availableTrain = (from s in context.Schedule
                                      where s.TrainID == trainID
                                      select s).FirstOrDefault();

                if(availableTrain == null)
                {
                    context.Schedule.Add(new Schedule
                    {
                        TrainID = trainID,
                        StartingCity = startingCity,
                        EndCity = endCity,
                        TravelTime = travelTime,
                        TicketPrice = ticketPrice
                    });

                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("The specified train is in use.");
                }
            }
        }

        public static void EditTrip(int trainID, string startingCity, string endCity, TimeSpan travelTime, decimal ticketPrice)
        {
            using (var context = new TicketsDB())
            {
                var existing = (from s in context.Schedule
                                where s.TrainID == trainID
                                select s).FirstOrDefault();

                if (existing != null)
                {
                    existing.StartingCity = startingCity;
                    existing.EndCity = endCity;
                    existing.TravelTime = travelTime;
                    existing.TicketPrice = ticketPrice;

                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("There is no train with that id.");
                }
            }
        }

        public static List<Schedule> GetAllSchedulesBetweenCities(string startingCity, string endCity)
        {
            using (var context = new TicketsDB())
            {
                return (from s in context.Schedule
                        where s.StartingCity.Equals(startingCity) && s.EndCity.Equals(endCity)
                        select s).ToList();
            }
        }
    }
}
