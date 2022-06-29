using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Construct
    {
        int n1;
        int n2;
        static int n3;
        public Construct(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }


        public void Name(int n1, int n2)
        {
            Console.Write(n1 + n2);
        }
        
        public static void Main()
        {
            Construct ob2 = new Construct(10, 15);
            Console.Write(ob2.n1);
            Console.Write(n3);
        }

    }
    class Basic
    {
        public void Same(int n2, int n3)
        {
            Console.WriteLine(n2 + n3);
        }
        class Deriv
        {

            public void Main(int n2, int n3)
            {
                Console.WriteLine(n2 + n3);
            }
            public static void Main()
            {
                Deriv ob = new Deriv();
                ob.Main(10, 15);

            }
        }
    }

    class Overload
    {
        public int Same(int a,int b)
        {
            return a + b;
        }
        public float Same(float a,float b)
        {
            return b - a;
        }
        public static void Main()
        {
            Overload ob = new Overload();
            Console.WriteLine(ob.Same(10, 15));
            Console.WriteLine(ob.Same(10.5F, 25.1F));
        }
    }

    class Override
    {
        public virtual void same()
        {
            Console.WriteLine("base");
        }
    }
    class  Mik : Override
    {
        public override void same()
        {
            Console.WriteLine("derived");
        }

        public static void Main(string[] args)
        {
            Mik ob = new Mik();
            ob.same();
        }
    }
    public abstract  class abst
    {
        public abstract void Main();
        

    }

   public class Sham : abst
    {
        public override void Main()
        {
            Console.WriteLine("sham");
        }

        public static void Main(string[]args)
        {
            Sham pb = new Sham();
            pb.Main();
        }
    }

    interface Nk
    {
      void Game();
    }

    class SK : Nk
    {
        public void Game()
        {
            Console.WriteLine("sham");
        }
        public static void Main()
        {
            SK ob = new SK();
            ob.Game();
        }
    }


    class Prop
    {
        int no;
        string name;

        public int No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }

        public static void Main()
        {
            Prop ob = new Prop();
            ob.No = 1;
            ob.Name = "nik";
            Console.WriteLine(ob.Name);
            Console.WriteLine(ob.No);
        }
    }
    
}
