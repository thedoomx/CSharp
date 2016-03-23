using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Ticket
    {
        public int ID { get; set; }
        public DateTime TripDateAndTime { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal PriceSold { get; set; }
        public int UserSoldTo { get; set; }
        public int TrainSeatsID { get; set; }

        public virtual User User { get; set; }
        public virtual TrainSeats TrainSeats { get; set; }
    }
}
