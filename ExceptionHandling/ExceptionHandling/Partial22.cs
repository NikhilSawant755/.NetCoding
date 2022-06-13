using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   
        partial class Partial22
        {
            int n;
            int m;
            Partial22(int m, int n)
            {
                this.m = m;
                this.n = n;
            }
            public void Display()
            {
                Console.WriteLine(m + n);
            }
            public static void Main()
            {
                Partial22 ob = new Partial22(10, 20);
                ob.Display();
                ob.same(20, 2);

            }


        }
        partial class Partial22
        {
            public void same(int a, int b)
            {
                Console.WriteLine(a + b);
            }
        }

    
}
