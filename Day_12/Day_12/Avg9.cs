using System;


namespace Day_12
{
    internal class Avg9
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no4");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int avg = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("average is "+avg);
        }
    }
}
