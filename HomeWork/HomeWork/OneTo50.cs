using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class OneTo50
    {
        //WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print negative number with its square
        public static void Main()
        {
            int odd;
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even no  "+i);
                }
                else
                {
                    Console.WriteLine("odd "+i);
                  
                }
            }
        }
    }
}
