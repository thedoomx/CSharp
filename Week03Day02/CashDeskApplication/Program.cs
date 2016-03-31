using CashDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CashDessk newDesk = new CashDessk();
            
            while (true)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(' ');


                if (arr[0].ToLower().Equals("exit"))
                {
                    break;
                }

                else if (arr[0].ToLower().Equals("takebill"))
                {
                    if (arr.Length < 2 || arr.Length > 2)
                    {
                        Console.WriteLine("invalid bill input");
                    }
                    else
                    {
                        int bill;
                        bool checker = int.TryParse(arr[1], out bill);
                        if (checker == false)
                        {
                            Console.WriteLine("invalid bill input");
                        }
                        else
                        {
                            if (ValidMoney(bill))
                            {
                                newDesk.TakeMoney(new Bill(bill));
                            }
                            else
                            {
                                Console.WriteLine(String.Format("not valid money {0}", bill));
                            }
                        }
                    }
                }

                else if (arr[0].ToLower().Equals("takebatch"))
                {
                    if(arr.Length < 2)
                    {
                        Console.WriteLine("invalid bill input");
                    }
                    else
                    {
                        List<Bill> list = new List<Bill>();
                        for (int i = 1; i < arr.Length; i++)
                        {
                            int bill;
                            bool checker = int.TryParse(arr[i], out bill);
                            if (checker == false)
                            {
                                Console.WriteLine(
                                    "invalid bill input in batch, no bills accepted from this batch"
                                    );
                                list = new List<Bill>();
                                break;
                            }
                            else
                            {
                                if(ValidMoney(bill))
                                {
                                    list.Add(new Bill(bill));
                                }
                                else
                                {
                                    Console.WriteLine(String.Format("not valid money {0}", bill));
                                }
                            }
                        }
                        newDesk.TakeMoney(new BatchBill(list));
                    }
                }

                else if (arr[0].ToLower().Equals("total")) {
                    Console.WriteLine(newDesk.Total());
                }

                else if (arr[0].ToLower().Equals("inspect"))
                {
                    newDesk.Inspect();
                }

                else
                {
                    Console.WriteLine("invalid user input");
                }
            }
        }

        public static bool ValidMoney(int bill)
        {
            int[] bills = new int[] { 2, 5, 10, 20, 50, 100 };

            if(!bills.Contains(bill))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
