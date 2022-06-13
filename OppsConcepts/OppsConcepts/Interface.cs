using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    interface parent
    {
        void Sum(int n );
    }
    interface parent2
    {
        void Sum2(int n);
    }


    class child : parent,parent2
    {
        public  void Sum(int n)
        {
            Console.WriteLine(n);
        }
        public void Sum2(int n)
        {
            Console.WriteLine(n);
        }
    }
    internal class Interface
    {
      
       public static void Main()
        {
            child ob = new child();
            ob.Sum(10);
            ob.Sum(20);
        }
    }
}
