using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class TicketsDB : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<DiscountCard> DiscountCard { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<TrainSeats> TrainSeats { get; set; }
        public DbSet<Train> Train { get; set; }
        public DbSet<City> City { get; set; }
    }
}
