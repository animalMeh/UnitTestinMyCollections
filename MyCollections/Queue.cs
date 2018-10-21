using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class Queue<T>
    {
        class Item
        {
            public T Value { get; set; }
            public Item Next { get; set; }
        }
        Item head;
        Item tail;

        public void Enqueue(T value)
        {
            var item = new Item{ Value = value , Next = null};
            if(head == null)
            {
                head = tail = item;
            }
            else
            {
                tail.Next = item;
                tail = item;
            }
        }
        public T Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException();
            var res = head.Value;
            head = head.Next;
            if (head == null) tail = null;
            return res;
        }
    }
}
