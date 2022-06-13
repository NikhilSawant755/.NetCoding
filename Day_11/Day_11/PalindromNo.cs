using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11
{
    internal class PalindromNo
    {
      
        public static void Main4()
        {
            int num1 = 373;
            int no;
            int result = 0;
            int sum = num1;
            while (num1 > 0)
            {
                no = num1 % 10;
                result = (result * 10) + no;//47
                num1 = num1 / 10;           }
            if (result==sum)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }
           
        }
    }
}
