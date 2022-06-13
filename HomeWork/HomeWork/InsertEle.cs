using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class InsertEle
    {
        //WAP to insert an element in a specific position into an array.
        public static void Main()
        {
            int[] no = new int[5];
            int num=12;
            int posit = 2;
            for(int i = 0; i <no.Length-1; i++)
            {
                Console.WriteLine("no of {0}", i);
                no[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            
        for(int i = no.Length - 1; i > posit; i--)
            {
                no[i] = no[i - 1];
            }
            no[posit] = num;
        }
    }
}
