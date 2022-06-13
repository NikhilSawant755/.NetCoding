using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class PrintOp10
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no3");
            int z = Convert.ToInt32(Console.ReadLine());
            int result = (x + y)*z;
            int result2= x*y+y*z;
            Console.WriteLine(result);
            Console.WriteLine(result2);


        }
    }
}
