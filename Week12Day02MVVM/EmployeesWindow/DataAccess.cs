using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesWindow
{
    static class DataAccess
    {
        static NorthwindEntities context = new NorthwindEntities();

        public static NorthwindEntities Context { get { return context; } }

        public static void SaveChanges()
        {
            context.SaveChanges();
        }

        public static List<Product> GetProductsForOrder(int orderId)
        {
            var order = context.Orders.Where(x => x.OrderID == orderId).FirstOrDefault();
            if (order == null)
            {
                return new List<Product>();
            }

            return order.Order_Details.Select(x => x.Product).ToList();
        }
    }
}
