using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class ArmstrongNo
    {
        public static void Main()
        {
            int no = 153;
            int p = no;
            int num = 0;
            int result = 0;
           
                while(no>0)
                {
                    num = no % 10;
                    result += num * num * num;
                    no = no / 10;
                }

            
            if (p == result)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }

              

            
        }
    }
}
