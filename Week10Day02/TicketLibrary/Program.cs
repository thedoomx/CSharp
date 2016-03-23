using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new TicketsDB())
            {
                City.AddCity("Plovidv");
                City.AddCity("Haskovo");
                City.DeleteCity("Gosho");
                City.AddCity("Varna");
                City.DeleteCity("Haskovo");

            }
        }
    }
}
