using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
     class Electricity
    {
        public static void Main5()
        {
            int unit, a, b, c;
            Console.Write("Input the unit consumed by the customer : ");
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit < 100)
            {
                a = unit * 0;
                Console.WriteLine("Bill is" + a);
            }
            else if (unit >= 100 && unit < 200)
            {
                b = (unit - 100) * 5;
                Console.WriteLine("Bill is" + b);
            }
            if (unit >= 200)
            {
                a = (unit - 200);
                b = (unit - a);
                c = (b - 100);
                Console.WriteLine("Bill is" + (a * 10 + c * 5));
            }
        }
    }
}
