using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class Reverse
    {
        public static void Main()
        {
            string name = "nikhil sawant";

            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            string ob = new string(arr);
            Console.WriteLine(ob);

        }
    }
}
