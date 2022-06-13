using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15Nested
{
    internal class Starpyramid
    {
        public static void Main4()
        { int rows = 10;
            int no = 1;
            for(int i = 1; i <= rows; i++) 
            {
                for (int k = rows-i; k >= 1; k--) //i=2 k=3
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++) //j=1
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
           
            
              
            
        }
    }
}
