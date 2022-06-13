using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class ArithmaticProgression
    {
        public static void Main()
        {
            int a = 2;
            int b = 4; //diff
            int n = 5; 

           int N_term = a + (n - 1) * b;
            Console.Write(N_term);

        }
    }
}
