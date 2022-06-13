using System;


namespace Day13
{
    internal class Overloading
    {

        void Sum(int no,int no2)
        {
            int sum = no + no2;
            Console.WriteLine(sum);
        }
         void Sum(int no, int no2,int no3)
        {
          int sum = no + no2+ no3;
            Console.WriteLine(sum);
        }
         void Sum(double no, double no2, double no3)
        {
            Double sum = no + no2-no3;
            Console.WriteLine(sum);
        }
        public static void Main4()
        {
            Overloading ob = new Overloading();
            ob.Sum(10, 15);
            ob.Sum(10,165,54);
            ob.Sum(10.4, 2.5,5.4);


        }
    }
}
