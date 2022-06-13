using System;


namespace Day14Project
{
    internal class Fact15
    {
        public static void Main4()
        {
            int fact = 1;
            /* for(int i = 1; i <= 5; i++)
             {
                 fact *= i;

             }
             Console.WriteLine(fact);*/
            int i = 1;
            while (i <= 5)
            {
                fact *= i;
                i++;
            }Console.WriteLine(fact);
        }
    }
}
