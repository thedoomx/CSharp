using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04day01
{
    class GenericDequeueClass<T>
    {
        private T[] arr;
        private int MAX_SIZE = 100;
        private int currentNumberOfItems = 0;

        public GenericDequeueClass()
        {
            arr = new T[MAX_SIZE];
        }

        public void Clear()
        {
            arr = new T[MAX_SIZE];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < currentNumberOfItems - 1; i++)
            {
                if (arr[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public T PeekFromEnd()
        {
            if (currentNumberOfItems == 0)
            {
                return arr[0];
            }

            return arr[currentNumberOfItems - 1];
        }

        public T PeekFromFront()
        {
            return arr[0];
        }

        private void Resize()
        {
            MAX_SIZE = MAX_SIZE * 2;
            T[] temp = new T[MAX_SIZE];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        public void AddToEnd(T item)
        {
            currentNumberOfItems++;

            if (currentNumberOfItems > MAX_SIZE)
            {
                Resize();
            }

            arr[currentNumberOfItems - 1] = item;
        }

        private void ResizeFront(T item)
        {
            MAX_SIZE = MAX_SIZE * 2;

            T[] temp = new T[MAX_SIZE];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i + 1] = arr[i];
            }

            temp[0] = item;
        }

        public void AddToFront(T item)
        {
            currentNumberOfItems++;

            if (currentNumberOfItems + 1 > MAX_SIZE)
            {
                ResizeFront(item);
            }
            else
            {
                T[] temp = new T[MAX_SIZE];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp[i + 1] = arr[i];
                }

                temp[0] = item;

                arr = temp;
            }
        }

        public T RemoveFromEnd()
        {
            T result = PeekFromEnd();

            if (currentNumberOfItems == 0)
            {
                arr[0] = default(T);
            }
            else
            {
                arr[currentNumberOfItems - 1] = default(T);

                currentNumberOfItems--;
            }

            return result;
        }

        public T RemoveFromFront()
        {
            T result = PeekFromFront();

            T[] temp = new T[MAX_SIZE];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                temp[i] = arr[i + 1];
            }

            arr = temp;

            return result;
        }

    }
}
