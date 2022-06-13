using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
   internal class FindOvel
    {
        public static void Main()
        {
            int count = 0;
            int Vcount = 0;
            string name = "Converting entire string to lower case to reduce the comparisons";
            name.ToLower();
            char[] name2 = name.ToCharArray();
            for(int i = 0; i < name.Length; i++)
            {
                if (name2[i] == 'a'|| name2[i] == 'e' || name2[i] == 'i' || name2[i] == 'o' || name2[i] == 'u' )
                {
                  
                    name2[i] = '#';
                  
                }
                else
                {
                    Vcount++;
                }

            }
            Console.Write(name2);
         
        }
    }
}
