using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Stack122
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(1);
            stack.Push(122);
           Console.WriteLine( stack.Pop()); // delete and return 
            

        }
    }
}
