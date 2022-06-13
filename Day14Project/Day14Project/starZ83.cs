using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{/*******
     *
    *
   *
  *
 *
*******/
    internal class starZ83
    {
        public static void Main4()
        {
          
            for(int i = 0; i <= 6; i++)
            {
              for (int j = 0; j <= 6; j++) //i=2 j=
              {
                    if (((i == 0 || i == 6) && j >= 0 && j <= 6) || i+ j == 6)
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
            Console.Write("\n");
        }
    }
}
