using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int DiscountCardID { get; set; }
        public int CreditCardNumber { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Ticket> Ticket { get; set; }
        public virtual DiscountCard DiscountCard { get; set; }
    }
}
