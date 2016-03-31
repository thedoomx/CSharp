using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill : IEnumerable
    {
        private Bill[] bills;

        public BatchBill(Bill[] bills)
        {
            this.bills = new Bill[bills.Length];

            for (int i = 0; i < bills.Length; i++)
            {
                this.bills[i] = bills[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public BatchBillEnum GetEnumerator()
        {
            return new BatchBillEnum(bills);
        }

        public BatchBill(List<Bill> list) : this(list.ToArray()) { }

        

        public int Count()
        {
            return this.bills.Length;
        }

        public int Total()
        {
            int result = 0;

            foreach (Bill item in this.bills)
            {
                result += item.Amount;
            }

            return result;
        }

        public override string ToString()
        {
            return this.Count() + ", " + this.Total();
        }
    }

    public class BatchBillEnum : IEnumerator
    {
        public Bill[] bills;

        int position = -1;

        public BatchBillEnum(Bill[] list)
        {
            this.bills = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < bills.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Bill Current
        {
            get
            {
                try
                {
                    return bills[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
