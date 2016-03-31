using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class OrderInfo
    {
        private List<Product> order;

        public OrderInfo(List<Product> order)
        {
            this.order = order;
        }

        public List<Product> Order
        {
            get
            {
                return this.order;
            }
        }

        public double Audit()
        {
            double result = 0;

            foreach (Product item in this.order)
            {
                result += item.PriceTaxed * item.ProductQuantity;
            }

            return result;
        }
    }
}
