using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class Equal
    {
        public static void Main1()
        {
            int no1;
            Console.WriteLine("enter your no1");
            no1 = Convert.ToInt32(Console.ReadLine());
            
            int no2;
            Console.WriteLine("enter your no2");
            no2 = Convert.ToInt32(Console.ReadLine());
           
            if (no1 == no2)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("numbers are not equal");
            }
        }
    }
}
