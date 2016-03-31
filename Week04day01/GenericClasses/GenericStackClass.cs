using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04day01
{
    class GenericStackClass<T>
    {
        private int MAX_SIZE = 100;
        private T[] arr;
        private int currentNumberOfItems = 0;

        public GenericStackClass()
        {
            arr = new T[MAX_SIZE];
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

        public void Push(T item)
        {
            currentNumberOfItems++;

            if (currentNumberOfItems > MAX_SIZE)
            {
                Resize();
            }

            arr[currentNumberOfItems - 1] = item;

        }

        public T Peek()
        {
            return arr[currentNumberOfItems - 1];
        }

        public void Pop()
        {
            Peek();

            arr[currentNumberOfItems - 1] = default(T);

            currentNumberOfItems--;
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
    }
}
