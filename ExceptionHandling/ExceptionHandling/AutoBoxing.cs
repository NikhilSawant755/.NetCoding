using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class AutoBoxing
    {
        public static void Main()
        {
            int no = 5;
            object na = no;  //boxing
            int d = (int)na; //unboxing

        }
    }
}
