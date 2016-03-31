using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders
    {
        public int ID { get; set; }
        public DateTime DateAndTimeOfOrder { get; set; }
        public float TotalPrice { get; set; }
        public int CustomerID { get; set; }

        public Orders()
        {

        }
    }
}
