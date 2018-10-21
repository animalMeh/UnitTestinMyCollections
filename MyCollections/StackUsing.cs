using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public static int ComputeFromPolis_Int32(string str)
        {
            var stack = new Stack<int>();
            var op = new Dictionary<char, Func<int, int, int>>();
            op['+'] = (a, b) => a + b;
            op['*'] = (a, b) => a * b;
            op['-'] = (a, b) => a - b;
            op['/'] = (a, b) => a / b;
            
            foreach (var symbol in str)
            {
                if (char.IsNumber(symbol))
                {
                    stack.Push(symbol - '0');
                    continue;
                }
                else if (op.Keys.Contains(symbol))
                {
                    var ar1 = stack.Pop();
                    var ar2 = stack.Pop();
                    stack.Push(op[symbol](ar1, ar2));
                }
                else throw new Exception("unexpected symbol " + symbol);
            }
            return stack.Pop();
        }
    }
}
