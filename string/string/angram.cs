using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class angram
    {
        public static void Main44()
        {
            String na = "act";
            string na2 = "cAt";

           string an= na2.ToLower();
       
            string an2 = na.ToLower();

            char[] cha = an.ToCharArray();
            char[] chb = an2.ToCharArray();

            Array.Sort(cha);
            Array.Sort(chb);

            string arr = new string(cha);
            string arr2 = new string(chb);

            if (arr == arr2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
        }
    }
}
