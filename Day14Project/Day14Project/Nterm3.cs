using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Nterm3
    {
        public static void Main4()
        {
            Console.WriteLine("enter your number");
            int no =Convert.ToInt32( Console.ReadLine());

            int result = 0;
            int i=1;
            /* for( i = 1; i <= no; i++)
             {
                 result += i;

             }Console.WriteLine(result);*/

            /*while (i<=no)
            {
                result += i;
                i++;


            }Console.WriteLine(result);*/

            do
            {
                result += i;
                i++;
                
            } while (i <= no);
            Console.WriteLine(result);
        }
       
    }
}
