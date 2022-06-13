using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Deligates
    {
        public delegate void ASum(int n1, int n2);
        public delegate void ASub(int n1, int n2);

        public void Sum(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public void Sub(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }


        public static void Main(string[] args)
        {
            Deligates ob = new Deligates();
         
            ASum ob1 = new ASum(ob.Sum);
            ASub ob2 = new ASub(ob.Sub);

            ob.Sum(10, 20);
            ob.Sub(10, 12);

          




        }
    }

    class N
    {
        public delegate void mydelegate(int a, int b);
        public delegate void mydel(string msg);

        class DelegateExample
        {
            public static void Add(int x, int y)
            {
                Console.WriteLine("Sum " + (x + y));
            }
            void Greet(string msg)
            {
                Console.WriteLine("Welcome " + msg);
            }

            public void Product(int x, int y)
            {
                Console.WriteLine("Product " + (x * y));
            }
            static void Main(String[] args)
            {
                DelegateExample t = new DelegateExample();
                mydelegate d1 = Add;
                mydel d2 = t.Greet;

                //single cast delegate
                //d1.Invoke(10,12);
                d1(12, 10);
                d2("Ketaki");

                //multicast delegate
                mydelegate d = t.Product;
                d = d + Add;
                d(12, 9);
            }
        }

    }
    public class c
    {
        public delegate void mydel(int a,int b);

       
            static void Main(string[]args)
            {
                mydel d = delegate (int a, int b)
                {
                    Console.WriteLine(a + b);
                };

             
            d(2, 25);

            mydel d2 = (a,b) => Console.WriteLine(a + b);
            d(54, 25);

            int square(int n)
            {
                return n * n;
            }
            
      
        }
            
               
            
        
    }
}
