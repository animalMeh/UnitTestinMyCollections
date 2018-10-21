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
            foreach(var symb in str)
            {
                switch (symb)
                {
                    case '(':
                    case '[':
                    case '{':
                    case '<':
                        stack.Push(symb);
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        var lastBkt = stack.Pop();
                        if (lastBkt != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        var lastBkt1 = stack.Pop();
                        if (lastBkt1 != '[') return false;
                        break;
                    case '}':
                        if (stack.Count == 0) return false;
                        var lastBkt2 = stack.Pop();
                        if (lastBkt2 != '{') return false;
                        break;
                    case '>':
                        if (stack.Count == 0) return false;
                        var lastBkt3 = stack.Pop();
                        if (lastBkt3 != '<') return false;
                        break;
                    default:continue;
                }
            }
            return stack.Count == 0;
        }
    }
}
