﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project
{
    internal class Star23
    {
       /* 1
          23
          456
          78910*/
        public static void Main4()
        {
            int no = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(no++);
                }
                Console.Write("\n");
            }
        }
    }
}
