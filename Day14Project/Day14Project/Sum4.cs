using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Sum4 { 


       
        public static void Main4()
        {
            int n; int sum=0;


            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("no is{0}", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            int avg = sum / 10;
            Console.WriteLine(avg);*/
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine("no _ {0} ", i);
                n = Convert.ToInt32(Console.ReadLine());
              
                sum += n;
                i++;

            }
            int avg = sum / 10;
            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
}

