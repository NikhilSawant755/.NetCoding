using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Prime1to100
    {
        public static void Main4()
        {
            int no =11;
            
            for (no = 2; no < 100; no++)
            {
                bool prime = true;
                for (int i = 2; i < no; i++)
                {
                    if (no % i == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime)
                {
                    Console.WriteLine(no);
                }
                
            }
        }
    }
}
