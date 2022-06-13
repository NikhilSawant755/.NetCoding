using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Table
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num +"*"+ i+ "=" + num*i);
            }
        }
            
    }
}
