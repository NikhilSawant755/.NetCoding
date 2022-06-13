using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class Fact
    {
        static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public static void Main()
        {
            int ans = factorial(1);
            Console.WriteLine(ans);
        }
    }
}
