using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Statickeyw
    {
        int no ;
        int no2 ;
        static String name = "sham";

        public Statickeyw(int no,int no2,String name)
        {
            this.no = no;
            this.no2 = no2;
           
        }

        public void Display()
        {
            Console.WriteLine(no + " " + no2 + " " + name);
        }
        public static void Main44()
        {
            Statickeyw ob = new Statickeyw(20,20,Statickeyw.name);
            ob.Display();

        }
    }
}
