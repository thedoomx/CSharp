using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class Product
    {
        private int price;
        private double priceTaxed;
        private string originCountry;
        private string productName;
        private int productQuantity;
        private int productId;

        public Product(int price, double priceTaxed, string originCountry, string name, int productQ, int id)
        {
            this.price = price;
            this.priceTaxed = priceTaxed;
            this.originCountry = originCountry;
            this.productName = name;
            this.productQuantity = productQ;
            this.productId = id;
        }

        public double PriceTaxed
        {
            get
            {
                return this.priceTaxed;
            }
        }

        public int ProductQuantity
        {
            get
            {
                return this.productQuantity;
            }
        }
        
        public int ProductId
        {
            get
            {
                return this.productId;
            }
        }

    }
}
