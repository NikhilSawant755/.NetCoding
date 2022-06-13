using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class CopyArray
    {
        public static void Main()
        {
            int[] no = { 10, 25, 45, 85, 96, 74, 325, 47 };
            int[] no2 = new int[no.Length];
          
            for (int i = 0; i < no.Length; i++)
            {
                no2[i]= no[i];

            }
            for (int i = 0; i < no2.Length; i++)
            {
                Console.Write(no2[i]);

            }
            for (int i = 0; i < no.Length; i++)
            {
                Console.Write("original array will be{0}",no[i]);

            }


        }
    }
}
