using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class DoubleChar
    {
        public static void Main()
        {
            string name ="nikhil sawant";
        
            int count = 0;
            int i;
            for( i = 0; i < name.Length; i++)
            {
                for(int j = i+1; j < name.Length; j++)
                {
                    if (name[i] == name[j])
                    {
                        count++;
                        Console.WriteLine(name[i]);
                       
                    }
                }
            }
           

        }
    }
}
