using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{      //10.	WAP to find the maximum and minimum value in an array.
    internal class MaxMinArray
    {
        public static void Main()
        {
            int[] no = { 10,55,8,3,5};
            int len = no.Length;
           int  max = no[0];
            for (int i = 1; i < len; i++)
            {
        
                if (max < no[i])
                {
                    max = no[i];
                  
                }
            }
            Console.WriteLine(max);
        }
    }
}

class Mini
{
    public static void Main()
    {
        int[] no = new int[5];
        int leng = no.Length;
        int min = no[0];
       
        
        for (int i = 0; i < leng; i++)
        {
            no[i] = Convert.ToInt32(Console.ReadLine());
            
           
            if ( no[i]<min )
            {
                min = no[i];
            }
        }Console.WriteLine(min);
    }
}