using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15Nested
{
    internal class Star12
    {/*1
      12
      123
      1234*/
        public static void Main4()
        {
            for (int i =1;i<=5;i++)
            {
                for (int j =1;j<=i;j++) 
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }
    }
}
