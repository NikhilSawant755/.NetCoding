using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class String34
    {
        public static void Main4()
        {
            string name = "hello how are you";
            String result = name.Substring(0, 5);
             
            if (result == "hello" || name.StartsWith("hello"))
            {
                Console.WriteLine(true);
            }
        }
    }
}
