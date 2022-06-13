using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class Password
    {
        public static void Main()
        {
            String name = "Satara@123";
            int len = name.Length;
            char[] na = name.ToCharArray();
            string sum = "";
            int capital = 0;
            int small = 0;
            int digit = 0;
            int ano = 0;
            for (int i = 0; i <len; i++)
            {
                if(na[i]>='a' && na[i] <= 'z')
                {
                    small++;
                }
               else if (na[i] >= 'A' && na[i] <= 'Z')
                {
                   capital++;
                }
               else if (na[i] >= '1' && na[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    ano++;
                }
            }
            if (ano >= 1 && digit >= 1&& capital >= 1 && small >= 1)
            {
                Console.WriteLine("pass is correct");
            }
            else
            {
                Console.WriteLine("pass is not correct");
            }
         
        }
    }
}
