using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TicketsDB())
            {
                var train = new Train() { TrainDescription = "purvi vlak" };

                var trainSeats = new TrainSeats { SeatClass = "purva klasa" };
                var trainSeats2 = new TrainSeats { SeatClass = "vtora klasa" };

                context.TrainSeats.Add(trainSeats2);
                context.Train.Add(train);
                context.TrainSeats.Add(trainSeats);

                context.SaveChanges();
            }
        }
    }
}
