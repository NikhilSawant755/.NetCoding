using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11
{
    internal class Palindrome
    {
        public static void Main4()
        {
            string name = "nikhil";
            var chars = name.ToCharArray();
            var length = name.Length;
            Console.WriteLine(length);
            var revString = string.Empty;
            for (var i = name.Length-1; i >= 0; i--)
            {
                revString = revString + name[i];


            }
            if (revString == name)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }
            

        }
    }
}
