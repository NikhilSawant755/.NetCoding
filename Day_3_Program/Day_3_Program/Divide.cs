using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class Divide
    { 
        public static void Main1()
        {
            int num1;
            Console.WriteLine("enter Your Number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Console.WriteLine("enter Your Number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
