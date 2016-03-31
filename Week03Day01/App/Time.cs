using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03
{
    class Time
    {
        private DateTime date;

        public Time()
        {

        }

        public Time(DateTime date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return date.ToString("hh:mm:ss dd.MM.yy");
        }

        public static Time Now()
        {
            Time nowTime = new Time(DateTime.Now);

            return nowTime;
        }
    }
}
