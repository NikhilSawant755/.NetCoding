using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class ReverseString
    {
        public static void Main()
        {
            String name = "Shubham";

            char[] na = name.ToCharArray();

            Array.Reverse(na);

            String name2 = new String(na);

            if (name2 == name)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not palindrom");
            }
        }
     

    }
}
