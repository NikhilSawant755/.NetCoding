using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15Nested
{
    internal class Cube
    { 
        public static void Main()
        { int sum = 0;
            int no;
            int result;
            Console.WriteLine("no");
            no = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= no; i++)
            {
                 result = i * 2;
                Console.WriteLine(result);
                sum += result;
            }
          
            Console.WriteLine(sum);
        }
    }
}
