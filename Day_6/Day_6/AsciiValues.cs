using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class AsciiValues
    {
        public static void Main4()
        {
            char c;
            Console.WriteLine("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
            

        }


    }
}
