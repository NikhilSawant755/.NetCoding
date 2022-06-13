using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class AbsoluteValue20
    {

        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int absolute = num1 - num2;
            Console.WriteLine(absolute);
            while (num1 > num2)
            {
                Console.WriteLine(absolute * absolute);
                break;
            }

        }
    }
}
