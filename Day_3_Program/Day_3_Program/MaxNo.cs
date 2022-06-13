using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class MaxNo
    {
        public static void Main2()
        {
            int no1;
            Console.WriteLine("enter your no1");
            no1 = Convert.ToInt32(Console.ReadLine());

            int no2;
            Console.WriteLine("enter your no2");
            no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 > no2)
            {
                Console.WriteLine("number 1 is max");
            }
            else
            {
                Console.WriteLine("number 2 is max");
            }
        }
    }
}
