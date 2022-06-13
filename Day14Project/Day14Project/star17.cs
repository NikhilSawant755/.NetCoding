using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{   /* 1
    2 2
   3 3 3
  4 4 4 4*/
    internal class star17
    {
        public static void Main4()
        { int rows=4;
           
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k >= 1; i--) // i = 1;K=3
                {
                    Console.WriteLine(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
               
            }
        }
    }
}
