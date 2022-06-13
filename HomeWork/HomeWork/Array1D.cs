using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Array1D
    {
        public static void Main()
        {
            int[] no = new int[10];
            int[] no2 = new int[5];
            for (int i = 0; i < 10; i++)
            {
                no[i] = Convert.ToInt32(Console.ReadLine());
                no2[i]=no[i];
            }

            for (int i = no2.Length / 2; i<no.Length; i++)
            {
                Console.WriteLine(no2[i]);
            }
           

        }
    }
}
