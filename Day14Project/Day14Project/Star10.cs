using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Star10
    {
/*1
12
123
1234*/
        public static void Main4()
        {
            int no = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++) //i=2 j=1
                {
                   
                   
                        Console.Write(j);
                   
                }
                Console.Write("\n");
            }
            
        }
    }
}
