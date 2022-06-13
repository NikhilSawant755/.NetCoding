using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class MultiOper7
    {
        public static void Main4()
        {
            Console.WriteLine("Enter no1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            MultiOper7 ob = new MultiOper7();
            ob.Display(num1,num2);
           
        }
        public void Sum(int n1,int n2)
        {
            int sum = n1 + n2;
            Console.WriteLine("sum is {0}",sum);

        }
        public void Sub(int num1, int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("substraction is {0}", sub);

        }
        public void Multi(int num1, int num2)
        {
            int Multi = num1*num2;
            Console.WriteLine("Multiplication is {0}",Multi);

        }
        public void Divide(int num1, int num2)
        {
            int divide = num1/num2;
            Console.WriteLine("Division is {0}", divide);

        }
        public void Mod(int num1, int num2)
        {
            int mod = num1 % num2;
            Console.WriteLine("mod is {0}", mod);

        }
        public void Display(int num1, int num2)
        {
            Sum(num1, num2);
            Sub(num1, num2);
            Multi(num1, num2);
           
            Divide(num1, num2);
            Mod(num1, num2);



        }
    }
}
