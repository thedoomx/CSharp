using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var productQuery = from product in Product.ListProducts
            //                   where product.ProductId >= 15 && product.ProductId <= 30
            //                   select new { ProductId = product.ProductId };

            //foreach (var item in productQuery)
            //{
            //    Console.WriteLine(item.ProductId);
            //}

            //Product a = new Product();
            //List<Product> list = a.GetProducts();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductId);
            //}

            //var orderQuery = from order in Order.ListOrders.Take(5)
            //                 orderby order.Name ascending
            //                 select new { OrderId = order.OrderId };

            //foreach (var item in orderQuery)
            //{
            //    Console.WriteLine(item.OrderId);
            //}

            //var firstSpecific = Order.GetOrders().Where(o => o.Products.Contains(2))
            //                                     .OrderBy(o => o.OrderDate)
            //                                     .Take(3)
            //                                     .ToList();

            //var firstSpecific2 = (from order in Order.GetOrders()
            //                     where order.Products.Contains(2)
            //                     orderby order.OrderDate
            //                     select new { OrderId = order.OrderId }).Take(3);


            //var query = Order.ListOrders.OrderBy(o => o.Name)
            //                            .Take(5);

            //var query = Order.ListOrders.Where(o => o.Products.Contains(2))
            //                            .OrderBy(o => o.OrderDate)
            //                            .Take(5);

            //var query = Category.ListCategories.OrderBy(c => c.CategoryName);

            //foreach (var category in query)
            //{
            //    var innerQuery = Product.ListProducts.Where(p => p.CategoryId == category.CategoryId);

            //    foreach (var product in innerQuery)
            //    {
            //        Console.WriteLine(product.ProductId + category.CategoryName);
            //    }
            //}

            //var query = from product in Product.ListProducts
            //            join category in Category.ListCategories
            //            on product.CategoryId equals category.CategoryId
            //            orderby category.CategoryName
            //            select new { CatName = category.CategoryName, ProductId = product.ProductId };

            //foreach (var item in query)
            //{
            //    Console.WriteLine(String.Format("Item: {0}, Category: {1}",item.ProductId, item.CatName));
            //}

            //var query = Category.ListCategories
            //    .OrderBy(c => c.CategoryName)
            //    .Join(Product.ListProducts, cat => cat.CategoryId, pr => pr.CategoryId, (cat, pr) => new { cat, pr });


            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.pr.ProductId + item.cat.CategoryName);
            //}

            //var query = Category.ListCategories.Zip(Product.ListProducts, (k, v) => new { Key = k, Value = v })
            //    .ToDictionary(x => x.Key, x => x.Value);

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Key.CategoryName + ": " + item.Value.Name);
            //}



        }
    }
}
