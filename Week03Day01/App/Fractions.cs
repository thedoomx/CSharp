using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03
{
    class Fractions
    {
        private int numinator;
        private int denominator;

        public Fractions(int numinator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException(String.Format("Denominator cannot be {0}.", denominator));
            }
            else
            {
                this.numinator = numinator;
                this.denominator = denominator;
            }
        }

        public int Numinator
        {
            get
            {
                return numinator;
            }
            set
            {
                numinator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException(String.Format("Denominator cannot be {0}.", value));
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public override string ToString()
        {
            return numinator + "/" + denominator;
        }

        public override bool Equals(Object obj)
        {
            if ((obj as Fractions).Numinator.Equals(this.Numinator) && (obj as Fractions).Denominator.Equals(this.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator==(Fractions a, Fractions b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!=(Fractions a, Fractions b)
        {
            if(!a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numinator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }

        public static Fractions operator +(Fractions a, Fractions b)
        {
            int lcd = getLCD(a, b);
            int multiplier = 0;

            multiplier = lcd / a.Denominator;
            a.Numinator = multiplier * (a.Numinator);
            multiplier = lcd / b.Denominator;
            b.Numinator = multiplier * (b.Numinator);

            return new Fractions(a.Numinator + b.Numinator, lcd);

        }

        public static Fractions operator -(Fractions a, Fractions b)
        {
            int lcd = getLCD(a, b);
            int multiplier = 0;

            multiplier = lcd / a.Denominator;
            a.Numinator = multiplier * (a.Numinator);
            multiplier = lcd / b.Denominator;
            b.Numinator = multiplier * (b.Numinator);

            return new Fractions(a.Numinator - b.Numinator, lcd);

        }

        private static int getLCD(Fractions a, Fractions b)
        {
            int i = a.Denominator;
            int j = b.Denominator;

            int greater = 0;
            int lesser = 0;

            if (i > j)
            {
                greater = i;
                lesser = j;
            }
            else if (i < j)
            {
                greater = j;
                lesser = i;
            }
            else
            {
                return i;
            }

            for (int k = 1; k <= lesser; k++)
            {
                if ((greater * k) % lesser == 0)
                {
                    return k * greater;
                }
            }

            return 0;
        }

        public static Fractions operator*(Fractions a, Fractions b)
        {
            return new Fractions(a.Numinator * b.Numinator, a.Denominator * b.Denominator);
        }

        public static double operator+(Fractions a, double b)
        {
            return ((double)a.Numinator / (double)a.Denominator) + b;
        }

        public static double operator-(Fractions a, double b)
        {
            return ((double)a.Numinator / (double)a.Denominator) - b;
        }
        
        public static double operator*(Fractions a, double b)
        {
            return ((double)a.Numinator / (double)a.Denominator) * b;
        }

        //public static explicit operator double(Fractions a)
        //{
        //    return new Fractions(d, d);
        //}
    }
}
