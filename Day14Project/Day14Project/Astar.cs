using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Astar
    {
        public static void Main()
        {
            for(int i = 1; i <= 8; i++)
            {
                if (i == 1)
                {
                    Console.Write("***");
                    continue;
                }
                if (i == 4)
                {
                    Console.Write("*****");
                }
                for (int j = 1; j <= 5; j++)
                { 
                    if(j==2 && j==3 && j == 4)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");

                    }
                   
                }
                Console.Write("\n");
            }
        }
    }
}
