using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class fibonasi35
    {
        public static void Main4()
        {

            int no1 = 0; int no2 = 1;
            int no3; int count = 10;

            Console.WriteLine(no1 );
            Console.WriteLine(no2);
            for (int i = 2; i <count; i++)
            {
               no3 = no1 + no2;
                Console.WriteLine(" "+no3);
                no1 = no2;
                no2 = no3;
            }

        }
    }
}
