using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Digit
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter Your number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num>=0 && num <= 9)
            {
                Console.WriteLine("number is single digit");
            }else if (num>=10 && num <= 99)
            {
                Console.WriteLine("number is double digit");
            }
        }
    }
}
