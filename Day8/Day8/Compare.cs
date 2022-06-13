using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Compare
    {
        public static void Main4()
        {
            int num1;int num2;
            Console.WriteLine("Enter your number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2){
                Console.WriteLine("equal");
            }else if (num1 > num2){
                Console.WriteLine(num1 + "is greater");
            }else if (num1 < num2){
                Console.WriteLine(num2 + "is greater");
            }else if (num2 != num1){
                Console.WriteLine(num2 + "is not equal to" + num1);
            }

        }
    }
}
