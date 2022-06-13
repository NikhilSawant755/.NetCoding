using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class age
     
    {
        public static void Main1()
        {
            int ageNo;
            Console.WriteLine("enter Your ageNo ");
            ageNo = Convert.ToInt32(Console.ReadLine());

            if (ageNo > 18)
            {
                Console.WriteLine("not teenage ");
            }
            else
            {
                Console.WriteLine( "teenage ");
            }
        }
       
    }
}
