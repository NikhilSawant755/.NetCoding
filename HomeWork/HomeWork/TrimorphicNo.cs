using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class TrimorphicNo
    {
        public static void Main()
        {

            int no = 5;
            int fact = 1;
            for (int i = 1; i <= no; i++)
            {
                if (no % i == 0) {
                    Console.WriteLine(i); 
                }
                fact = fact * i;

               
            }
           

        }
    }
}
