using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11
{
    internal class Day12
    {
        public static void Main4()
        {
            Console.WriteLine("Enter your number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Arithmatic ob = new Arithmatic();
            ob.sum(num1, num2);
            ob.sub(num1, num2);
            ob.suc(num1, num2);
           
        }
    }
    class Arithmatic
    {
        public int no = 0;
        public void sum(int n1,int n2)
        {
            int sum = n1 + n2;
            display(sum,"sum");
        }
        public void sub(int n1,int n2)
        {
            
            int sub = n1 - n2;
        
            display(sub,"sub");
        }
        public void suc(int no, int n2)
        {
            no = 7;

            int suc = no + n2;

            display(suc, "suc");
        }
        public void display(int result, string name)
        {
            if (name == "sum")
            {
                Console.WriteLine("the {0} is {1}" ,name ,result);
            }
             if (name == "sub")
            {
                Console.WriteLine("the {0} is {1}" ,name ,result);
            }
            if (name == "suc")
            {
                Console.WriteLine("the {0} is {1}", name, result);
            }



        }
    }
}
