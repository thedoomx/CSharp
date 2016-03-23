using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataStore
    {
        public static List<Product> GetProducts()
        {
            return Product.ListProducts.Where(p => p.ProductId >= 1 && p.ProductId <= 100).ToList();
        }

        public static List<Order> GetOrders()
        {
            return Order.ListOrders.Where(o => o.OrderId >= 201 && o.OrderId <= 300).ToList();
        }

        public static List<Category> GetCategories()
        {
            return Category.ListCategories.Where(c => c.CategoryId >= 101 && c.CategoryId <= 200).ToList();
        }
    }
}
