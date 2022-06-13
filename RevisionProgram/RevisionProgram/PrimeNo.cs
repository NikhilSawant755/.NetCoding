using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class PrimeNo
    {
        public static void Main()
        {
            int no = 17;
            bool prime = true;

            for(int i = 2;i < no; i++)
            {
                if (no % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
