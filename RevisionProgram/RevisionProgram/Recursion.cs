using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class Recursion
    {
        static void reverse (string str)
        {
            if (str != "")
            {
                Console.WriteLine(str[str.Length - 1]);
                reverse(str.Substring(0, str.Length - 1));
            }

            static void Main()
            {
                reverse("prasad");
            }
        }
    }
}
