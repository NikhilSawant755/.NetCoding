using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class countSentence
    {
        public static void Main()
        {
            String name = "nikhil sawant cat dog main";
            int count = 0;
         
            for (int i = 0; i <= name.Length-1; i++)
            {
                if(name[i]== ' ' && char.IsLetter(name[i+1]) && (i > 0))
                {
                    count++;
                }
            }
            count++;
            Console.WriteLine("Total number of words in the given string: " + count);


        }
    }
}
