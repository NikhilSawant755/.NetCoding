using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class ComputeSumPrime26
    {
        public static void Main4()
        { int no1 = 2;
            int no2 = 500;
            int j;
           
            for (int i = 2;i<=no2;i++)
            {
                for ( j=2;j<=i;j++){
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j){
                    Console.WriteLine(j);
                    
                }
            }
            

        }
    }
}
