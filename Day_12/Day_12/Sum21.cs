using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Sum21
    {
        public static void Main4()
        {

            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("sum is"+sum);
            if (num1 == 20 || num2 == 20)
            {
                Console.WriteLine(true + " because num is 20");
            }else if (sum == 20)
            {
                Console.WriteLine(true+" because sum is 20");
            }
        }
    }
}
