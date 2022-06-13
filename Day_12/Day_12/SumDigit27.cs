using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class SumDigit27
    {
        public static void Main4()
        {
            int num = 125;
            int no;
            int result=0;
            while(num>0)
            {
                no = num % 10;
                result += no;
                num = num / 10;
                
            }Console.WriteLine(result);
        }
    }
}
