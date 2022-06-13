using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class DublicateElement
    {
        public static void Main()
        {
            string name = "cat dog mai sham cat ram dog";
            string[] value = name.Split(" ");
            int counter=0;
            for (int i = 0; i < value.Length; i++)
            {
               counter = 1;
                for (int j = i+1; j < value.Length; j++)
                {
                    if (value[i]==(value[j]))
                    {
                        counter++;
                        Console.WriteLine(value[i]);
                      
                    }
                }
                
            }
        
        }
    }
}
