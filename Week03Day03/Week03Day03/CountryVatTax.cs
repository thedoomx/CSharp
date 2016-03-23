using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03Day03
{
    class CountryVatTax
    {
        private int countryId;
        private int vatTax;

        public CountryVatTax(int country, int tax)
        {
            this.countryId = country;
            this.vatTax = tax;
        }

        public int CountryId
        {
            get
            {
                return this.countryId;
            }
        }

        public int VatTax
        {
            get
            {
                return this.vatTax;
            }
        }
    }
}
