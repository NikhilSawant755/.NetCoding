using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Floyed22
    {
/*1
01 
101
0101 
10101*/
        public static void Main4()
        {
            
           int p ;
           int q ;
            for (int i = 1; i <= 5; i++) 
            {
                if (i % 2 == 0) 
                {
                    p = 1;
                    q = 0;

                }
                else
                {
                    p = 0;
                    q = 1;

                }
                for (int k = 1; k <= i; k++) 
                {
                    if (k % 2 == 0)
                    {
                        Console.Write("{0}", p);        
                    }
                    else
                    {
                        Console.Write("{0}", q);
                    }
                  
                   
                   
                }
                Console.Write("\n");
            }
        }
    }
}
