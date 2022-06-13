// See https://aka.ms/new-console-template for more information
using System;
namespace Day11
{
    class Program
    {
        public static void Main4()
        {

            Console.WriteLine("enter your name");
           string name= Console.ReadLine();
           
            var chars = name.ToCharArray();
            int length = name.Length;
            var revStr = string.Empty;
            for(int i = name.Length - 1; i >= 0; i--)
            {
              revStr=revStr+chars[i];
            }
            Console.WriteLine(revStr);

            if (name == revStr)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }


        }

      
    }


    class Program2
    {
        static int num;

        public void Same()
        {
            num = 40;
            Console.WriteLine("i m same");
        }
        public void Shaam()
        {
            Console.WriteLine("i m Shaam");
        }
        public static void Main()
        {
            num = 10;
            num = 12;
            Program2 ob = new Program2();
            ob.Shaam();
            ob.Same();

            Shapes ob2 = new Shapes();
            ob2.Rectangle();
            ob2.Square();

            Shapes.Nikhil();

        }
        
    }
    class Shapes
    {
        int length = 20;
        int breadth = 10;
        int side = 10;
        public void Rectangle()
        {
            int area = length * breadth;
        }
        public void Square()
        {
            int area = side * side;
        }
        public static void Nikhil()
        {
            Console.WriteLine("nikhil");
        }
    }



}
