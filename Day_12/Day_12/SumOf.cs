using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class SumOf
    {
        public static void Main4()
        {
            Console.WriteLine("Enter your num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("sum of "+  num1 +"  and "+ num2  +" is "+result);

        }
    }
}
