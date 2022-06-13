using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class putNo
    {
        public static void Main()
        {
            int[] no = { 10, 25, 54, 65, 24 };

            int pos = 3;
            int element = 22;

            for(int i = no.Length - 1; i > pos - 1; i--)
            {
                no[i] = no[i - 1];
            }
            no[pos - 1] = element;
            for (int i = 0; i <no.Length; i++)
            {
                Console.WriteLine(no[i]+" ");
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            int num1;
            Console.WriteLine("enter your number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Console.WriteLine("enter your number1");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.WriteLine("num 1 is {0} num2 is {1}", num1, num2);
        }
    }
    public class Class2
    {
        public static void Main()
        {
            int i = 1; int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k =" + k + "i =" + i);

        }
    }
     class Class1
    {

        public static void Main(String[] args)
        {

            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
        // b will 0 1 2 so a print 3 times

    }
}
