using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            var queue = new Queue<char>();
            queue.Enqueue('1');
            queue.Enqueue('2');
            queue.Enqueue('3');
           
            Console.WriteLine(queue.Dequeue());

        }
    }
}
