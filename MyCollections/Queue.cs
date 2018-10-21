using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }

    }

    public class Queue<T> : IEnumerable<T>
    {

        QueueItem<T> head;
        QueueItem<T> tail;

        #region

        public void Enqueue(T value)
        {
            var item = new QueueItem <T>{ Value = value, Next = null };
            if (head == null)
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
        #endregion

        //public class QueueEnumerator : IEnumerator<T>
        //{
        //    Queue<T> queue;
        //    QueueItem<T> item;

        //    public QueueEnumerator(Queue<T> queue)
        //    {
        //        this.queue = queue;
        //        item = null;
        //    }

        //    public T Current
        //    {
        //        get { return item.Value; }
        //    }
        //    object IEnumerator.Current
        //    {
        //        get { return this.Current; }
        //    }

        //    public bool MoveNext()
        //    {
        //        if (item == null)
        //            item = queue.head;
        //        else item = item.Next;
        //        return item != null;
        //    }

        //    public void Dispose()
        //    {

        //    }

        //    public void Reset()
        //    {

        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            //return new QueueEnumerator(this);
            var current = head;
            while(current!= null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        //explicit implementation interface's members
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
