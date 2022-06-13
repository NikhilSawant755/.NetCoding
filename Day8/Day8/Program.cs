// See https://aka.ms/new-console-template for more information
using System;
namespace Day8
{
    class Program
    {
        public static void Main4()
        {
            int num;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt16(Console.ReadLine());
            if (num > 5)
            {
                Console.WriteLine(num+" is greater than 5");
            }
            else if(num==5)
            {
                Console.WriteLine(num + " is equal to 5");
            }
            else
            {
                Console.WriteLine(num + " is less than to 5");
            }


        }
    }
}
