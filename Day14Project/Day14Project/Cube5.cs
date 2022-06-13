using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Cube5
    {
        public static void Main4()
        {
            /* for(int i= 1; i <= 5; i++)
             {
                 Console.WriteLine(i+"^"+"3"+"="+i*i*i);
             }*/

            int i = 1;
            while ( i <= 5)
            {
                Console.WriteLine(i + "^" + "3" + "=" + i * i * i);
                i++;
            }
        }
    }
}
