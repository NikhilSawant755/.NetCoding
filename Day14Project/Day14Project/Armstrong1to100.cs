using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Armstrong1to100
    {
        public static void Main()
        {
            int no ;
            int num;
            
            for (int i = 1; i <= 1000; i++)
            {
           int result = 0;
                no = i;
                while (no > 0)
            {
          
                num = no % 10;
                result+=(num * num * num);
                no = no / 10;
                
            }
           
            if (result ==i)
            {
                Console.WriteLine(i);
            }
                
            }
        }
    }
}
