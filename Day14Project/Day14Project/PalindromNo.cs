using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class PalindromNo
    {
        public static void Main()
        {
            int no=105 ;
            int num;
            int result = 0;
            int i = no;
          
                while (no > 0)
            {
                num = no % 10; 
                result =(result* 10)+num;  
                no=no / 10;
                Console.WriteLine("palin");
            }
            if (result == i)
            {
                Console.WriteLine("palin");
            }
            

            
        }
    }
}
