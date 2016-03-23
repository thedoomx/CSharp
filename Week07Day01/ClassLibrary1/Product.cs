using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        private static List<Product> products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 3, Name = "golf" },
                new Product { ProductId = 2 , CategoryId = 100, Name = "polo"},
                new Product { ProductId = 3, CategoryId = 1, Name = "allroad" },
                new Product { ProductId = 100, CategoryId = 101, Name = "x6" },
                new Product { ProductId = 21, CategoryId = 2, Name = "GLK" },
                new Product { ProductId = 101, CategoryId = 231, Name = "punto" },
                new Product { ProductId = 231, CategoryId = 2, Name = "italia"}

            };
        public static IReadOnlyCollection<Product> ListProducts
        {
            get
            {
                return products.AsReadOnly();
            }
        }
    }
}
