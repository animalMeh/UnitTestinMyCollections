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
          
            var queue = new Queue<char>();
            queue.Enqueue('1');
            queue.Enqueue('2');
            queue.Enqueue('3');
           foreach(var q in queue)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine(queue.Dequeue());

        }
    }
}
