using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{	//8.	WAP to print all negative elements in an array and also count total number of negative elements in an array.
    internal class NegativeEle
    {
        public static void Main()
        {
            int[] no = { 2, 4, 6, -2, -1, -12, 14, -16, -18, 20 };
            int len = no.Length;
            int no2 = 0;
           
            for(int i = 0; i < len; i++)
            {
                if (no[i] < 0)
                {
                    Console.WriteLine(no[i]);
                    no2++;
                }
            }
            Console.WriteLine(no2);
        }
    }
}
