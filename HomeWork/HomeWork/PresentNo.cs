using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class PresentNo
    {
        public static void Main()
        {
           // WAP to search for a given number in an array and accordingly print the index if exists.
               int[] no = { 20, 58, 65, 200, 8774, 441 };
            int no2=441;
            int index = 0;
            for(int i = 0; i < no.Length; i++)
            {
                ++index;
                while (no2 == no[i])
                {
                    Console.WriteLine(no2+"present at no " + index +" th  index");
                    break;
                }
                
            }
            
        }
    }
}
