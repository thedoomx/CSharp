using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day02
{
    public abstract class Car
    {
        public virtual bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }

    public class Audi : Car
    {
        private int mileage;

        public Audi(int mileage)
        {
            this.mileage = mileage;
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return base.IsEcoFriendly(testing);
        }
    }

    public class Volkswagen : Car
    {
        private int mileage;

        public Volkswagen(int mileage)
        {
            this.mileage = mileage;
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return testing;
        }
    }

    public class BMW: Car
    {
        private int mileage;

        public BMW(int mileage)
        {
            this.mileage = mileage;
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return base.IsEcoFriendly(testing);
        }
    }

    public class Honda: Car
    {
        public override bool IsEcoFriendly(bool testing)
        {
            return base.IsEcoFriendly(testing);
        }
    }

    public class Skoda: Car
    {
        public override bool IsEcoFriendly(bool testing)
        {
            return base.IsEcoFriendly(testing);
        }
    }
}
