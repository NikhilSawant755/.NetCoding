using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15Nested
{
    internal class Startrangle23
    {
        public static void Main4()
        {
            {
                int no = 1;
                int rows = 4;
                for (int i = 1; i <= rows; i++)
                {
                    for (int k = rows - i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("{0} ",no++);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
