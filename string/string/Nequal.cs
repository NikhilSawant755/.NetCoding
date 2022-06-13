using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class Nequal
    {
        public static void Main(String[] args)
        {
            String name = "aaabbbccc";
            int n = 3;
            int tem = 0;
            int leng = name.Length;
            int chars = leng / n;
            string[] equal = new string[n];
            if (leng % n != 0)
            {
                Console.WriteLine("this can not divided in to" + n + " equal parts");
            }
            else
            {
                for (int i = 0; i < leng; i = i + chars)
                {
                    String part = name.Substring(i, i + chars);
                    equal[tem] += part;
                    tem++;

                }
                for (int i = 0; i < equal.Length; i++)
                {
                    Console.WriteLine(equal[i]);
                }
               

            }
        }
    }
}
