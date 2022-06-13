using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class Anagram
    {
        public static void Main()
        {
            string na = "act";
            string na2 = "cat";
           string n1= na.ToUpper();
            string n2 = na2.ToUpper();

            char[] arr1 = n1.ToCharArray();
            char[] arr2 = n2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            string n = new string(arr1);
            string nk = new string(arr2);

            if (n == nk)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not a anagram");
            }

        }
    }
}
