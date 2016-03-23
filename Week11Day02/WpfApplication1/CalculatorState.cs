using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class CalculatorState
    {
        public float? FirstNumber { get; set; }
        public float? SecondNumber { get; set; }
        public string Operation { get; set; }

        public CalculatorState()
        {

        }
    }
}
