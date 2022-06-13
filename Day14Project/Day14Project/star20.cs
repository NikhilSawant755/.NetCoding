using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
                                               /* *
                                                 ***
                                                ***** */
{
    internal class star20
    {
        public static void Main4()
        {
            int rows = 25;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
            

        }
    }
   
    
}
