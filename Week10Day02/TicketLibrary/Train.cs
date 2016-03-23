using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Train
    {
        public Train()
        {
            TrainSeats = new List<TrainSeats>();
        }

        public int ID { get; set; }
        public int Seats { get; set; }
        public string TrainDescription { get; set; }

        public virtual List<TrainSeats> TrainSeats { get; set; }

        public static List<Train> GetAllTrains()
        {
            using (var context = new TicketsDB())
            {
                List<Train> result = new List<Train>();

                result = context.Train.ToList();

                return result;
            }
        }

        public static void AddTrain(int seats, string trainDescription)
        {
            using (var context = new TicketsDB())
            {
                context.Train.Add(new Train() { Seats = seats, TrainDescription = trainDescription });
                context.SaveChanges();
            }
        }

        public static void RemoveTrain(int id)
        {
            using (var context = new TicketsDB())
            {
                var train = (from t in context.Train
                             where t.ID == id
                             select t).FirstOrDefault();

                if (train != null)
                {
                    context.Train.Remove(train);
                }
                else
                {
                    Console.WriteLine("There is no such train id");
                }
                context.SaveChanges();
            }
        }

        public static void EditTrain(int id, int seats, string trainDescription)
        {
            using (var context = new TicketsDB())
            {
                var train = (from t in context.Train
                            where t.ID == id
                            select t).FirstOrDefault();

                if(train != null)
                {
                    train.Seats = seats;
                    train.TrainDescription = trainDescription;
                    context.SaveChanges();
                }
            }
        }
    }
}
