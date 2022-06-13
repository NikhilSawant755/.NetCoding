using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Reverse37cs
    {
        public static void Main4()
        {
            int no = 12345;
            int result = 0;
            int num;
            while (no > 0)
            {
                 num = no % 10;
                result = (result*10)+num;
                no = no / 10;
            }Console.WriteLine(result);
        }
    }
}
