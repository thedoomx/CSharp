using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class ShopInventory
    {
        private List<Product> list;

        public ShopInventory(List<Product> list)
        {
            this.list = list;
        }

        public double Audit()
        {
            double result = 0;

            foreach (Product item in this.list)
            {
                result += item.PriceTaxed * item.ProductQuantity;
            }

            return result;
        }

        public double RequestOrder(OrderInfo order)
        {
            int foundCounter = 0;

            foreach (Product orderedItem in order.Order)
            {
                foreach (Product item in this.list)
                {
                    if (orderedItem.ProductId == item.ProductId)
                    {
                        if (orderedItem.ProductQuantity <= item.ProductQuantity)
                        {

                            foundCounter++;
                        }
                    }
                }
            }

            if (foundCounter != order.Order.Count)
            {
                throw new ArgumentException("Not available in inventory.");
            }

            return order.Audit();
        }
    }
}
