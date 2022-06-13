using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Series26
    {
        public static void Main4()
        {
            int no =8128;
            int num;int result = 0;

            for(int i = 1; i <= no; i++) 
            {
               if( no % i == 0)
                {
                    result += i;
                  
                }
               
            }
            if (result == (no*2))
            {
                Console.WriteLine("perfect no");
            }
            else
            {
                Console.WriteLine("no perfect ");
            }
        }
    }
}
