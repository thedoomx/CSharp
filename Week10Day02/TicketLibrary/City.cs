using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<Schedule> Schedule { get; set; }

        public City()
        {
            Schedule = new List<Schedule>();
        }

        public static void AddCity(string name)
        {
            using (var context = new TicketsDB())
            {
                var existing = (from c in context.City
                                where c.Name.Equals(name)
                                select c).FirstOrDefault();

                if (existing == null)
                {
                    context.City.Add(new City() { Name = name });
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(string.Format("{0} is already in database.", name));
                }
            }
        }

        public static void DeleteCity(string name)
        {
            using (var context = new TicketsDB())
            {
                var city = (from c in context.City
                            where c.Name.Equals(name)
                            select c).FirstOrDefault();

                if(city != null)
                {
                    context.City.Remove(city);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(string.Format("There is no {0} city in database", name));
                }
            }
        }

        public static List<City> GetAllCities()
        {
            using(var context = new TicketsDB())
            {
                return context.City.ToList();
            }
        }
    }
}
