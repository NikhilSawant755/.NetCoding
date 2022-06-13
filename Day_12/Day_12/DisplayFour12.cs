using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class DisplayFour12
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", num1, num1, num1, num1);
            Console.WriteLine("{0}{1}{2}{3}", num1, num1, num1, num1);
            Console.WriteLine("{0} {1} {2} {3}", num1, num1, num1, num1);
            Console.WriteLine("{0}{1}{2}{3}", num1, num1, num1, num1);
        }
    }
}
