using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
     class Name
    {
        public void Nikh()
        {
            Console.WriteLine("nik parent");
        }
    }
     class Sham : Name
    {
        public void Nikh()
        {
            Console.WriteLine("nik child");
        }
    }
    internal class StaticClass
    {
        public static void Main44()
        {
          Name ob = new Sham();
            ob.Nikh();
           
            
        }
    }
}
