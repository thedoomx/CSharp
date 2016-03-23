using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class VatTaxCalculator
    {
        private List<CountryVatTax> list;
        private CountryVatTax defaultTax;

        public VatTaxCalculator(List<CountryVatTax> list, CountryVatTax defaultTax)
        {
            this.list = list;
            this.defaultTax = defaultTax;
        }

        public double CalculateTax(int price, int countryId)
        {
            CountryVatTax correspondingVatTax = null;

            foreach (CountryVatTax item in this.list)
            {
                if (item.CountryId == countryId)
                {
                    correspondingVatTax = item;
                    break;
                }
            }

            if (correspondingVatTax == null)
            {
                throw new NotSupportedException("Country not supported.");
            }

            return price * (correspondingVatTax.VatTax / 100.0);
        }

        public double CalculateTax(int price)
        {
            return price * (defaultTax.VatTax / 100.0);
        }
    }
}
