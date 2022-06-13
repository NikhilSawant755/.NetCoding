using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Age11
    {
        public static void Main4()
        {
            Console.WriteLine("write your age");
            int age = Convert.ToInt32(Console.ReadLine());
          while (age == 25)
            {
                Console.WriteLine("you look older than 25");
                break;
            }
          
        }
    }
}
