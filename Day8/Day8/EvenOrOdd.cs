using System;

namespace Day8
{
    internal class EvenOrOdd
    {
        public static void Main4()
        {
            int num;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
       
    }
}
