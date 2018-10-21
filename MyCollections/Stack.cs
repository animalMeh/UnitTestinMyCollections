using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public class Stack<T>
    {
        List<T> list = new List<T>();

        public int Count => list.Count;


        public void Push(T value)
        {
            list.Add(value);
        }

        public T Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }
}
