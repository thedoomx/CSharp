using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<int> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        private static List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 1, Products = new List<int>() { 1, 2}, Name = "a" },
                new Order { OrderId = 2, Products = new List<int>() { 3, 100 }, Name = "b" },
                new Order { OrderId = 3, Products = new List<int>() { 21, 100 }, Name = "c" },
                new Order { OrderId = 100, Products = new List<int>() {101, 2 }, Name = "d" },
                new Order { OrderId = 21, Products = new List<int>() {231, 2 }, Name = "a" },
                new Order { OrderId = 101, Products = new List<int>() { 2, 100 }, Name = "b" },
                new Order { OrderId = 231, Products = new List<int>() { 2, 231 }, Name = "b" }

            };
        public static IReadOnlyCollection<Order> ListOrders
        {
            get
            {
                return orders.AsReadOnly();
            }
        }

    }
}
