// See https://aka.ms/new-console-template for more information
using System;
namespace Day_3_Program
{
  public class AddTwoNo
    {
        public static void Main1()
        {
            int num1;
            Console.WriteLine("enter Your Number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Console.WriteLine("enter Your Number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("result is "+ result);
        }
    }
}
