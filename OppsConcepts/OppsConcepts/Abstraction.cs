using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
     
    abstract class Animal
        {
       public abstract void sleep();
        public void add()
        {
            Console.WriteLine("add");

        }

        }
    class Nik2 : Animal
    {
      public override  void sleep()
        {
            Console.WriteLine("sum");
        }
    }
    internal class Abstraction
    {
        
        public static void Main()
        {
            Nik2 ob = new Nik2();
            ob.add();
            ob.sleep();
        }
    }
}
