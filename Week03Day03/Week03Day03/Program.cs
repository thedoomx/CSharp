using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            VatTaxCalculator calc = new VatTaxCalculator(new List<CountryVatTax>()
            {
                new CountryVatTax(1, 20),
                new CountryVatTax(2, 10),
                new CountryVatTax(3, 40)
            },
            new CountryVatTax(1, 20));

            Product banana = new Product(100, 100 + calc.CalculateTax(100, 2), "Bulgaria", "bananas", 5, 1);
            Product apple = new Product(120, 120 + calc.CalculateTax(120, 2), "Serbia", "apples", 6, 2);

            List<Product> products = new List<Product>()
            {
                banana,
                apple
            };

            ShopInventory shop = new ShopInventory(products);

            List<Product> order = new List<Product>()
            {
                new Product(100, 100 + calc.CalculateTax(100, 2), "Bulgaria", "bananas", 4, 1),
                new Product(120, 120 + calc.CalculateTax(120, 2), "Serbia", "apples", 6, 2)
            };

            OrderInfo orderInfo = new OrderInfo(order);

            Console.WriteLine(shop.RequestOrder(orderInfo));
        }
    }
}
