using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class DuplicateSentence
    {
        public static void Main()
        {
            string para = "i m a good boy nd i have good habits";

            string[] para2 = para.Split(" ");
           
            for(int i = 0; i < para2.Length; i++)
            {
                
                for (int j = i+1; j < para2.Length; j++)
                {
                    if (para2[i].Equals(para2[j]))
                    {
                        Console.WriteLine(para2[i]+" "+i);
                    }
                }
                
                
            }
        }
    }
}
