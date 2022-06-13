using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class PosiNig
    {
        public static void Main4()
        {
            int no1;
            Console.WriteLine("enter your no1");
            no1 = Convert.ToInt32(Console.ReadLine());
            if (no1 > 0)
            {
                Console.WriteLine("no is +ve No");
            }
            else
            {
                Console.WriteLine("no is -ve No");
            }
        }
    }
}
