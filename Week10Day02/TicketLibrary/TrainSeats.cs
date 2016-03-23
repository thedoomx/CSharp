using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class TrainSeats
    {
        public TrainSeats()
        {
            Ticket = new List<Ticket>();
        }
        public int ID { get; set; }
        public int TrainID { get; set; }
        public int SeatID { get; set; }
        public string Occupied { get; set; }
        public string SeatClass { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual List<Ticket> Ticket { get; set; }
        public virtual Train Train { get; set; }

    }
}
