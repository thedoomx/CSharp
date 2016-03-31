using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03
{
    class Pair<T, U>
    {
        private T x;
        private U y;

        public T X
        {
            get
            {
                return x;
            }
        }

        public U Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            return x + ", " + y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(Object obj)
        {
            if((obj as Pair<T, U>).X.Equals(this.X) && (obj as Pair<T, U>).Y.Equals(this.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator==(Pair<T, U> first, Pair<T, U> second)
        {
            if(first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!=(Pair<T, U> first, Pair<T, U> second)
        {
            if(!first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
