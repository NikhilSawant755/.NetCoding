using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class StarPattern
    {
        public static void Main()
        {
            
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
           
        }
    }
}
