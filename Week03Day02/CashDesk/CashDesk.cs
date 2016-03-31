using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDessk
    {
        private int money;
        private Dictionary<int, int> container = new Dictionary<int, int>();

        public CashDessk()
        {
            this.money = 0;
        }

        public int Money
        {
            get
            {
                return this.money;
            }

            set
            {
                money = value;
            }
        }


        public void TakeMoney(Bill bill)
        {
            this.money += bill.Amount;

            if (this.container.ContainsKey(bill.Amount))
            {
                this.container[bill.Amount]++;
            }
            else
            {
                this.container.Add(bill.Amount, 1);
            }
        }

        public void TakeMoney(BatchBill batch)
        {
            this.money += batch.Total();

            foreach (Bill bill in batch)
            {
                if (this.container.ContainsKey(bill.Amount))
                {
                    this.container[bill.Amount]++;
                }
                else
                {
                    this.container.Add(bill.Amount, 1);
                }
            }
        }

        public int Total()
        {
            return this.money;
        }

        public void Inspect()
        {
            var list = container.Keys.ToList();
            list.Sort();

            Console.WriteLine(String.Format("We have a total of {0}$ int the desk", this.Total()));
            Console.WriteLine("We have the following count of bills, sorted in ascending order: ");
            foreach (int key in list)
            {
                Console.WriteLine(String.Format("{0}$ bills - {1}", key, container[key]));
            }
        }
    }
}
