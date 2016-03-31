using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill //Bill<T> where T : IComparable
    {
        private int amount;

        public Bill(int amount)
        {
            this.amount = amount;
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Value cannot be 0 or below.");
                }
                else
                {
                    this.amount = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("A {0}$ bill", amount);
        }

        public override bool Equals(object obj)
        {
            if ((obj as Bill).Amount.Equals(amount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Bill a, Bill b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Bill a, Bill b)
        {
            if (!a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Value(Bill a)
        {
            return a.Amount;
        }

        public static explicit operator int (Bill a)
        {
            return a.Amount;
        }


    }
}
