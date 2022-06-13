using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class StarPatternRev
    {
        public static void Main()
        {
            int row = 10;
            for(int i = 1; i < row; i++)
            {
                for (int j =row-i; j >0; j--) //i=1;j=10
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
        }
    }
}
