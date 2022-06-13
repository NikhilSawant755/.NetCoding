using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class StringFunction
{
       
        public static void Main44()
        {
            /* String name = "nikhil sawant       ";

             Console.WriteLine(name.StartsWith("n"));
             Console.WriteLine(name.EndsWith("t")); // it shows true false

             Console.WriteLine(name.Replace("sawant", "pawar")); // replace
             Console.WriteLine(name.Length);                     
             Console.WriteLine(name.Substring(7)); //7 char skim krke next char will be printed
             Console.WriteLine(name.Substring(0, 6));  //
             Console.WriteLine(name.Trim());         // it cancel the spaces starting or ending
             Console.WriteLine(name.IndexOf("l"));   
             Console.WriteLine(name.LastIndexOf("a"));*/


            string na = Console.ReadLine().ToUpper();
            string na2 = Console.ReadLine().ToUpper();
            char[] nai= na.ToCharArray();
            char[] nai2 = na2.ToCharArray();
            Array.Sort(nai);
            Array.Sort(nai2);
            string s4 = new string(nai);
            string s5 = new string(nai2);
            if (s4 == s5)
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
