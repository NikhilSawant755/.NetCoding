using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Armstrong29
    {
        public static void Main4()
        {
            int no = 153;
            int result = 0;
            int num;
            int temp = no;
            while (no != 0)
            {
                num = no % 10;
                result += num*num*num;
                no = no / 10;


            }
            if(result == temp){
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
        }
    }
}
