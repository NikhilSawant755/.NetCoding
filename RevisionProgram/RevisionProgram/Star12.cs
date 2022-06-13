using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class Star12
    {
        public static void Main()
        { int rows = 10;
            int no = 1;
            for(int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)// j=1 i=1
                {
                    Console.Write(no++);
                }
                Console.Write("\n");
            }
        }
    }
}
