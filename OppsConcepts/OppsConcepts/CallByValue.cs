using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class CallByValue
    {
        public void Sum(int n)
        {
            n +=n ;
            Console.WriteLine(n);
        }
        public static void Main()
        {
            int n = 10;
            CallByValue ob = new CallByValue();
            Console.WriteLine(n);
            ob.Sum(n);
            Console.WriteLine(n);
        }
    }
}
