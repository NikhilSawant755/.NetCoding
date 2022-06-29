using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Deligat
    {
        public delegate void Same(int a, int b);
        public void same(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main()
        {
            Deligat ob = new Deligat();

            Same on = new Same(ob.same);
            ob.same(10, 15);



        }
    }

    class typeDelig
    {
        public delegate void Sum(int a, int b);
        public delegate void Sub(int a, int b);
        public delegate void Game(string msg);
        public static void Asum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public  void Asub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void game(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Main(string[]args)
        {

            //single cast
            typeDelig ob2 = new typeDelig();
            Sum ok = Asum;
         
            Game ok3 = new Game(ob2.game);
            ok(10, 20);
          
            ob2.game("hello");

            //multicast deli

            Sum ob = Asum;
            Asum(10, 15);
            Sum ob3 = Asum;
            Asum(2, 5);
            Sum ob4 = ob2.Asub;
            ob2.Asub(2,10);



        }
       

    }
}
