using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Table7
    {
        public static void Main4()
        { int no = 8;
            for(int i = 1; i <= no; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}*{1}={2}, ", i, j, i * j);
                }
            }
        }
    }
}
