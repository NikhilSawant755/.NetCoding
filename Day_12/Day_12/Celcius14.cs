using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Celcius14
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num + 273.15+"kelvin");
            Console.WriteLine((num * (9 / 5) + 32));
        }
    }
}
