using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Star9
    {/*
**
***
****
*****
******
*******
********
*********
**********
***********/
        public static void Main4()
        {
            for(int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
