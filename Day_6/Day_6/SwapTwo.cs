using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class SwapTwo
    {
        public static void Main4()
        {
            int a = 10;
            int b = 5;
            int c;
           
            c= a-b;
           
            b = a;
            a = c;
            Console.WriteLine("b ="+b);
            Console.WriteLine("a ="+a);
        }
    }
}
