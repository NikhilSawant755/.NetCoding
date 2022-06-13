using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Prime32
    {
        public static void Main4()
        {
            int no = 12;
            bool prime = true;
            for(int i = 2; i < no; i++)
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
