using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericStackClass<int> stack = new GenericStackClass<int>();

            //stack.Push(5);
            //stack.Push(5);
            //Console.WriteLine(stack.Contains(0));
            //Console.WriteLine(stack.Peek());

            //GenericDequeueClass<int> dequeue = new GenericDequeueClass<int>();
            //dequeue.AddToFront(3);
            //dequeue.RemoveFromEnd();
            //Console.WriteLine(dequeue.RemoveFromEnd());

            Console.WriteLine("How many combinations do u want to enter?");
            string number = Console.ReadLine();
            int n;
            bool res = int.TryParse(number, out n);

            if (res == true)
            {
                int index = 0;

                while(index < n)
                {

                }
            }
        }
    }
}
