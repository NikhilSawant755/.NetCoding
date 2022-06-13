using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class Anagram2
    {
        public static void Main()
        {
            Console.WriteLine("string1");
            string n1 = Convert.ToString(Console.ReadLine()); //dog

            Console.WriteLine("string2");
            string n2 = Convert.ToString(Console.ReadLine()); // god

            string nam = n1.ToLower();
            string nam2 = n2.ToLower();

            char[] no = nam.ToCharArray();
            char[] no2 = nam2.ToCharArray();

            Array.Sort(no);
            Array.Sort(no2);

            string po = new string(no);
            string p = new string(no2);

            if (po == p)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is anagram");
            }

        }
    }
}
