using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class CallByRef
    {
        public void sum(ref int n)
        {
            n *= 10;
            Console.WriteLine(n);
        }
        public static void Main()
        {
            int n = 10;
            
            CallByRef ob = new CallByRef();

            Console.WriteLine(n);
            ob.sum(ref n);
            Console.WriteLine(n);

        }
    }
}
