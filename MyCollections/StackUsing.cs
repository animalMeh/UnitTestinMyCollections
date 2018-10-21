using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MyCollections
{
    public class StackUsing
    {
        // checking 4 open-closed  bkt in string( or it can me query)
        public static bool CheckBKT(string str)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['['] = ']';
            dict['{'] = '}';
            dict['<'] = '>';
            foreach (var symb in str)
            {
                if (dict.Keys.Contains(symb))
                {
                    stack.Push(symb);
                }
                else if (dict.Values.Contains(symb))
                {
                    if (stack.Count == 0) return false;
                    var lastBkt = stack.Pop();
                    if (dict[lastBkt] != symb) return false;
                };
            }
            return stack.Count == 0;
        }
    }
}
