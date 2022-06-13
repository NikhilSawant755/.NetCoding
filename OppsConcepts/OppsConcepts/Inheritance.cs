using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    interface nik
    {
       int mai(int no);
        
    }
    interface nik2
    {
        public void mai4();
        
    }
    class Parent:nik,nik2
    {


      public  int  mai(int no)
        {
            return 10;
        }
        public void mai4()
        {
            Console.WriteLine("bn");
        }
    }

   
    
    internal class Inheritance
    {
        public static void Main()
        {
            Parent ob = new Parent();
           Console.WriteLine( ob.mai(2));
            ob.mai4();
            

        }
    }
}
