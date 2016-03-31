using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CustomerAddress { get; set; }
        public float? Discount { get; set; }

        public Customers()
        {

        }
    }
}
