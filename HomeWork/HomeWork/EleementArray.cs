using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    // WAP to add elements to single dimensional int array and print elements from 1D array
    //WAP to accept dimension of 1D array and create and accept data in that array.Calculate the average value of array elements.
    internal class EleementArray
    {
        public static void Main()
        {
            int[] no = new int[5];
            int avg = 0;
            int result=0;
            for (int i = 0; i < no.Length; i++)
            {
                no[i] = Convert.ToInt32(Console.ReadLine());
                avg += no[i];
               result= avg / no.Length;
            }Console.WriteLine(result);
        }
    }
}
