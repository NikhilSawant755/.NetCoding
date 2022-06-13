using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{              /*1
                
	           2 2 2

            3 3 3 3 3

         4 4 4 4 4 4 4*/

    internal class Pattern12
    {
        public static void Main()
        { int rows = 4;
            int no = 1;
            int j;
            for(int i = 1; i <= rows; i++)
            {
                for (int k =5 ; i <= rows; i++)
                { 

                }
                for (j = 1; j <= i; j++)
                    {
                        Console.Write(no++);

                    }
                

                Console.Write("\n");
            }
         
        }
    }
}
