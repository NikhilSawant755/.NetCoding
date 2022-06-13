using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Teneger
    {
        public static void Main4()
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>=13 && age >=18)
            {
                Console.WriteLine("he is not teneger");
            }
            else
            {
                Console.WriteLine("he is teneger");
            }

        }
    }
}
