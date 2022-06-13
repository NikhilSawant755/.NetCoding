using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Natural2
    {
        public static void Main4()
        {
            int Count=1 ;
            int result = 0;
            /* for (Count = 1; Count <=10; Count++)

             {
                  result += Count;



             }
             Console.WriteLine(result);*/
            /*while (Count<10)
            {
                Count++;
                result += Count;

            }
            Console.WriteLine(result);*/

            do
            {
                result += Count;
                Count++;

            }
            while (Count <= 10);
            Console.WriteLine(result);
        }
        
    }
}
