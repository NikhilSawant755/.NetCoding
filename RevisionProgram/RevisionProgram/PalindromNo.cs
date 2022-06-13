using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class PalindromNo
    {
        public static void Main()
        {
            int no = 353;
            int num = 0;
            int sum=0;
            int temp = no;
            while (no > 0)
            {
                num = no % 10;
                sum = (sum*10)+num;
                no = no / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("palindrom no");
            }
            else
            {
                Console.WriteLine("not palindrom no");
            }
        }
    }
}
