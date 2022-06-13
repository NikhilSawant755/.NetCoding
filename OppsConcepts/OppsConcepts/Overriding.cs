using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{ class Name
    {
        public int no = 100;


       public Name(int i) 
        {
            int a = i + i;
            Console.WriteLine(a+"parent");
        }


        public virtual void Ga()
        {
            Console.WriteLine("nikhil");
        }
       

    }

    class Same : Name
    {
         int no = 500;
        
        public Same(int i):base(i)
        { 
            i = i + i;
            Console.WriteLine(i+"child");
        }
        public override void Ga()
        {
            base.Ga();
            Console.WriteLine("child");
            //for override variable;
            Console.WriteLine(base.no);

        }

    }
    internal class Overriding
    {
        public static void Main()
        {
            Same ob = new Same(10);
            ob.Ga();
           
        }
    }
}
