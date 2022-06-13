using System;


namespace Day_12
{
    internal class Swap
    {
        public static void Main4()
        {
            int temp;
            int fno = 5;
            int Sno = 6;

            temp = fno;
            fno = Sno;
            Sno = temp;

            Console.WriteLine("first no is "+fno);
            Console.WriteLine("secound no is "+Sno);
        }
    }
}
