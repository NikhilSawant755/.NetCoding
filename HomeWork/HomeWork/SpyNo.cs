using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class SpyNo
    {
        public static void Main()
        {
            int no = 123;
            int num;
            int sum = 0;
            int multi = 1;
            int reNo = no;
            while (no != 0)
            {
                num = no % 10;
                sum += num;
                multi *= num;
                no = no / 10;
            }
            if (multi == sum)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("not spy number");
            }
        }
    }
}
