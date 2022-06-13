using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class ComputeSum19
    {
        public static void Main10()
        {
            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(result);
            if (num1 == num2)
            {
                Console.WriteLine(result*result*result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
