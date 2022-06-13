using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class BasicDay1
    {
        public static void Main()
        {
            Console.WriteLine("name");
            string name = Console.ReadLine();
            Console.WriteLine("age");
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Name=" + name + " age:" + age);
                Console.WriteLine("character at 3 position is " + name[2]);
                try
                {
                    Console.WriteLine("Two numbers");
                    int no1 = int.Parse(Console.ReadLine());
                    int no2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(no1 / no2);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Age should be numeric");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Propgation
    {
        static void divide(int a, int b)
        {
            Console.WriteLine("division" + a / b);
        }
        static void Main()
        {
            try
            {
                divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("in main exception handled");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(" main end");
        }


    }

    class final
    {
        static int divide(int a, int b)
        {
            try
            {
                Console.WriteLine("division=");
                return a / b;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("always exicuted");
            }
            return 0;
        }
        static void Main()
        {
            Console.WriteLine("main start");
            int result = divide(10, 2);
            Console.WriteLine("answer " + result);
            Console.WriteLine("main ends");
        }

    }

    

}
    

