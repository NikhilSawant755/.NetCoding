﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class FibonasiSeries
    {
        public static void Main()
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1 + "\n" + n2);
            int no = 20;
            int n3;
        
            for(int i = 2; i <= no; i++)
            {
                n3 = n2 + n1;
                Console.WriteLine(n3);
                
                n1 = n2;
                n2 = n3;

            }
        }
    }
}
