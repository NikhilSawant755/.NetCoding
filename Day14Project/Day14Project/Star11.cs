using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Star11
    {
        public static void Main4()
        {
            /* 1
               22
               333
               4444 */
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }

        }
    }
}
