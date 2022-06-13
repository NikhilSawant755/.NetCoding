using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class OuputAdd
    {
        public static void Main()
        {              // 3, 5,  7, 9
            int[] no = { 1, 2, 3, 4, 5 };
            int sum ;
            for(int i = 0; i < no.Length; i++)
            {
                sum = no[i] + no[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
}
