using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Multi6
    {
        public static void Main4()
        {
            /*for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(15 + " * " + i + " = " + 15 * i);
            }*/
            int i = 1;
            do
            {
             
                Console.Write(15+"*"+i+"="+ 15*i+"," );
                ++i;

            } while( i <=10);
        }
    }
}
