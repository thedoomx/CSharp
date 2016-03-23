using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    public class AverageAggregator
    {
        public event EventHandler AverageChanged;

        public decimal Average { get; set; }
        private int sumOfNumbers;
        private int counter;

        public AverageAggregator()
        {

        }


        public void AddNumber(int n)
        {
            sumOfNumbers += n;
            counter++;
            decimal temp = sumOfNumbers / counter;

            if (Average != temp)
            {
                Average = temp;
                if(AverageChanged != null)
                {
                    AverageChanged(this, new EventArgs());
                }
            }
        }
    }
}
