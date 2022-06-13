using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class Averg
    {
        public static void Main1()
        {
            int num1;
            Console.WriteLine("enter Your Number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Console.WriteLine("enter Your Number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3;
            Console.WriteLine("enter Your Number3");
            num3 = Convert.ToInt32(Console.ReadLine());
            int num4;
            Console.WriteLine("enter Your Number4");
            num4 = Convert.ToInt32(Console.ReadLine());

            int avg = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("average is " + avg);
        }
    }
}
