using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class CheckTwoInt18
    {
        public static void Main4()
        {

            Console.WriteLine("Enter your num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool result = num1>= 0 && num2 < 0 ? true : false;
            Console.WriteLine(result);
        }
    }
}
