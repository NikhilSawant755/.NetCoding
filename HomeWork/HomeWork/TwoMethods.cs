using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
    /* Write two methods that return the average of an array with following headers.
   a. public static int average(int[] array)
b. public static double average(double[] array).
Write main and invoke the 2 methods.*/
{
    internal class TwoMethods
    {
        public static int average(int[] array)
        {
          
            int[] no = { 10, 15, 25, 30 };
            int sum = 0;
            int leng = no.Length;
            for(int i = 0; i < leng; i++)
            {
                sum += no[i];
            }
            
            return sum/leng;
        }

        public static double average(double[] array)
        {
           
            double[] num = { 10.4, 10, 5.2, 5.3, 2 };
            int leng = num.Length;
            double sum2 = 0;
            for (int i = 0; i < leng; i++)
            {
                sum2 += num[i];
            }
            return sum2/leng;
        }

        public static void display()
        {
            Console.WriteLine(average(new double[0]));
        }
        public static void Main()
        {
            TwoMethods.display();
            Console.WriteLine( TwoMethods.average(new int[0]));
        }
    }
}
