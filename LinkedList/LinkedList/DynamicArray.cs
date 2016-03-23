using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DynamicArray<T>
    {
        private static int capacity = 10;
        private T[] arr = new T[capacity];
        private int itemsInArr = 0;

        public void Add(T item)
        {
            if (itemsInArr == capacity - 1)
            {
                Resize();
            }

            arr[itemsInArr] = item;

            itemsInArr++;
        }

        private void Resize()
        {
            T[] temp = arr;

            if (capacity < 2048)
            {
                arr = new T[capacity * 2];
            }
            else
            {
                arr = new T[capacity + 256];
            }

            for (int i = 0; i < temp.Count(); i++)
            {
                arr[i] = temp[i];
            }

        }

        public int Count()
        {
            return this.itemsInArr;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < itemsInArr; i++)
            {
                if (arr[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < itemsInArr; i++)
            {
                if(arr[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public void InsertAt(int index, T value)
        {
            if (itemsInArr == capacity - 1)
            {
                Resize();
            }

            T[] temp = new T[arr.Length];
            arr.CopyTo(temp, 0);

            arr[index] = value;
            itemsInArr++;

            for (int i = index + 1; i < itemsInArr + 1; i++)
            {
                arr[i] = temp[i - 1];
            }
        }

        public void Remove(T value)
        {
            if (arr.Contains(value))
            {
                int index = 0;

                for (int i = 0; i < itemsInArr; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        index = i;
                    }
                }

                T[] temp = new T[arr.Length];
                arr.CopyTo(temp, 0);

                for (int i = index; i < itemsInArr; i++)
                {
                    arr[i] = temp[i + 1];
                }

                itemsInArr--;
            }
        }

        public void RemoveAt(int index)
        {
            T[] copy = new T[arr.Length];
            arr.CopyTo(copy, 0);

            for (int i = index; i < itemsInArr; i++)
            {
                arr[i] = copy[i + 1];
            }

            itemsInArr--;
        }

        public void Clear()
        {
            capacity = 10;
            arr = new T[capacity];
            itemsInArr = 0;
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        public T[] ToArray()
        {
            T[] result = new T[itemsInArr];

            for (int i = 0; i < itemsInArr; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }
    }
}
