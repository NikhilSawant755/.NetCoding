using System;


namespace Day_15Nested
{
    internal class Star333
    {
        public static void Main4()
        {
                     /* 1
                        22
                        333
                        4444 */
        for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }

        }
    }
}
