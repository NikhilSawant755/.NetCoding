using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Reverse28
    {
        public static void Main4()
        {
            String name = "Display the pattern like pyramid using the alphabet.";
            var chars = name.ToCharArray();
            var length = name.Length;
            Console.WriteLine(length);
            string revname = string.Empty;
            for(var i = name.Length-1; i >=0; i--)
            {
                revname = revname+chars[i];
            }Console.WriteLine(revname);
        }
    }
}
