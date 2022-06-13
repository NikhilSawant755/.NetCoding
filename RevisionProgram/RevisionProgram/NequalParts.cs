using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class NequalParts
    {
        public static void Main()
        {
            string name = "aaabbbccc";
            int n = 3;
            int len = name.Length;
            int chars = len / n;
            char[] arr = name.ToCharArray();
            string[] arr1 = new string[n];
           
            int temp = 0;
            if (len % n != 0)
            {
                Console.WriteLine("this can not divided in to" + n + " equal parts");
            }
            else
            {
                for(int i = 0; i < len; i=i+chars)
                {
                    string part = name.Substring(i, i + chars);
                    arr1[temp] = part;
                    temp++;
                }
              
                    Console.WriteLine(arr1[temp]);
                
            }

           
        }
    }
}
