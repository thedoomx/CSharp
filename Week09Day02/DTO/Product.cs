using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal SinglePrice { get; set; }
        public int CategoryID { get; set; }

        public Product()
        {

        }
    }
}
