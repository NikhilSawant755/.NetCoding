using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Program
{
    internal class Vowel
    {
        public static void Main4() { 
        char ch;
        Console.WriteLine("enter your char");
        ch = Convert.ToChar(Console.ReadLine().ToLower());

            if (ch == 'a' || ch == 'e' || ch = 'i' || ch == 'o' || ch = 'u');
            {
                Console.WriteLine("vowel");
            }else{
                Console.WriteLine("consonant");
            }
        }
    }
}
