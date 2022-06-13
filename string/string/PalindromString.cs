using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class PalindromString
    {
        public static void Main()
        {
            string name = "ketki";
            string name2="";
            Console.WriteLine("original  "+name);
            for(int i = name.Length-1; i >=0; i--)
            {
                name2 += name[i];

            }
            Console.WriteLine("Duplicate "+name2);

            if (name == name2)
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
