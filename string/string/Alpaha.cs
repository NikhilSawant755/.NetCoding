using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class Alpaha
    {
        public static void Main()
        {
            string name = "NikhIL";
            char cha;
            int count = 0;
            int lower = 0;
            int digit = 0;
            int symbol = 0;

            for (int i = 0; i < name.Length; i++)
            {
                cha=name[i];
                if(cha>='A' && cha<= 'Z')
                {
                    count++;
                }else if(cha>='A' && cha <= 'Z')
                {
                    lower++;
                }else if(cha>=0 && cha <= 9)
                {
                    digit++;
                }
                else
                {
                    symbol++;
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(count);
            Console.WriteLine(digit);
        }
    }
}
