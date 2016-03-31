using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node Head { get; set; }

        public void AddHead(T item)
        {
            this.Head = new Node(item, Head);
        }

        public void AddFirst(T item)
        {
            this.Head = new Node(item, null);
        }

        public void Add(T item)
        {
            if (this.Count() == 0)
            {
                AddFirst(item);
            }
            else
            {
                Node temp = Head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = new Node(item, null);
            }
        }

        public void insertAfter(T key, T item)
        {
            Node temp = Head;

            while (temp != null && !temp.Value.Equals(key))
            {
                temp = temp.Next;
            }

            if (temp != null)
            {
                temp.Next = new Node(item, temp.Next);
            }
        }

        public void insertBefore(T key, T item)
        {
            if (Head == null)
            {
                throw new ArgumentException("head == null");
            }

            if (Head.Value.Equals(key))
            {
                AddHead(item);
            }
            else
            {
                Node prev = null;
                Node current = Head;

                while (current != null && !current.Value.Equals(key))
                {
                    prev = current;
                    current = current.Next;
                }

                if (current != null)
                {
                    prev.Next = new Node(item, current);
                }
            }

        }

        public void Remove(T value)
        {
            if (Head == null)
            {
                throw new ArgumentException("head == null");
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
            }
            else
            {
                Node current = Head;
                Node prev = null;

                while (current != null && !current.Value.Equals(value))
                {
                    prev = current;
                    current = current.Next;
                }

                prev.Next = current.Next;
            }
        }

        public void InsertAt(int index, T value)
        {
            int currentIndex = 0;

            if (index == 0)
            {
                AddHead(value);
            }
            else if (index > Count())
            {
                throw new ArgumentException("baq daleche otidohme");
            }
            else
            {
                Node current = Head;
                Node prev = null;

                while (current != null && currentIndex < index)
                {
                    currentIndex++;
                    prev = current;
                    current = current.Next;
                }

                prev.Next = new Node(value, current);
            }
        }

        public void RemoveAt(int index)
        {
            int currentIndex = 0;

            if (index == 0)
            {
                Head = Head.Next;
            }
            else if (index >= Count())
            {
                throw new ArgumentException("baq daleche otidohme");
            }
            else if (index == Count() - 1)
            {
                Node current = Head;
                Node prev = null;

                while (currentIndex < index)
                {
                    currentIndex++;

                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
            }
            else
            {
                Node current = Head;
                Node prev = null;

                while (current != null && currentIndex < index)
                {
                    currentIndex++;

                    prev = current;
                    current = current.Next;
                }

                prev.Next = current.Next;
            }

        }

        public int Count()
        {
            int result = 0;

            if (Head != null)
            {
                Node temp = Head;
                result++;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                    result++;
                }
            }

            return result;
        }

        public void Clear()
        {
            Head = null;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        public LinkedListEnum GetEnumerator()
        {
            return new LinkedListEnum(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class LinkedListEnum : IEnumerator<T>
        {
            private Node Head;
            private Node Cur;



            public LinkedListEnum(Node head)
            {
                this.Head = head;
                this.Cur = null;
            }

            public bool MoveNext()
            {
                if (Head == null)
                {
                    return false;
                }

                if (Cur == null)
                {
                    Cur = Head;
                    return true;
                }
                else if(Cur.Next != null)
                {
                    Cur = Cur.Next;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                Cur = Head;
            }

            public void Dispose()
            {
                
            }

            public T Current
            {
                get
                {
                    return Cur.Value;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
        }

        public class Node
            {
                public T Value { get; set; }
                public Node Next { get; set; }

                public Node(T value, Node next)
                {
                    this.Value = value;
                    this.Next = next;
                }
            }
    }
}