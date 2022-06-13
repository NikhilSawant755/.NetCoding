using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Perfect28
    {
        public static void Main()
        {

            int num = 28;
           
          
            for( num = 1; num < 100; num++) {
                int result = 0;
                for (int i = 1; i < num; i++)
            {
                if (num % i==0) {
                    result += i;

                }

                }
                if (num == (result))
                {
                    Console.WriteLine(num);

                }
              
            }
           


        }
    }
}
