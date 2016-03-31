using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Map<T, U>
    {
        private DynamicArray<T> keys = new DynamicArray<T>();
        private DynamicArray<U> values = new DynamicArray<U>();
        private int itemsInMap = 0;

        public void Add(T key, U value)
        {
            if (keys.Contains(key))
            {
                values[keys.IndexOf(key)] = value;
            }
            else
            {

                keys.Add(key);
                values.Add(value);

                itemsInMap++;
            }
        }

        public bool ContainsKey(T key)
        {
            if(keys.Contains(key))
            {
                return true;
            }

            return false;
        }

        public bool ContainsValue(U value)
        {
            if (values.Contains(value))
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            keys = new DynamicArray<T>();
            values = new DynamicArray<U>();
            itemsInMap = 0;
        }

        public void Remove(T key)
        {
            values.RemoveAt(keys.IndexOf(key));
            keys.Remove(key);
            itemsInMap--;
        }
    }
}
