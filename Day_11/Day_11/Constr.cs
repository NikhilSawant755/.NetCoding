using System;


namespace Day_11
{
    internal class Constr
    {
        int num1, num2;
        public Constr()
        {
            num1 = 100;
            num2 = 200;


        }
        public Constr(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;


        }
        public  void Display()
        {
            Console.WriteLine("result1 is {0} and result2 is {1} ", num1, num2);
        }
        public static void Main()
        {
            Constr ob = new Constr(10,15);
            ob.Display();
            Constr ob2 = new Constr();
            ob2.Display();


        }
    }
}
