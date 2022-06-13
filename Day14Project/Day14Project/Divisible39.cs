using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Divisible39
    {
        public static void Main4()
        { int no = 90;
            for(int i = 100; i < 200; i++)
            {
                no = i;
                if (no % 9 == 0)
                {
                    Console.WriteLine(no);
                }
            }
        
        }
    }
}
