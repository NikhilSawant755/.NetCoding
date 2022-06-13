using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class Class
    {
        int num = 10;
        int num2 = 15;
       

        void Same(int no1,int no2)
        {
            int sum = no1 + no2;
            Console.WriteLine(sum);
        }

        public static void Main()
        {
            Class ob = new Class();
            ob.Same(5,15);


        }
    }
}
