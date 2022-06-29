using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Except
    {
        public static void Main()
        {
            string name2 = "abs";
            int n = Convert.ToInt32(name2);
            int no = 10;
            int[] no2 =new int[5];
            int[] no3 =  { 2, 4, 4 };
            string name = null;
           
            try
            {
                Console.WriteLine(name.Length);
                for(int i= 0; i<= no3.Length; i++)
                {
                    Console.WriteLine(no3[i]);
                }
                int result = no / 0;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("always exicuted");

            }
           
            

        }
    }

 public class UserDefinedException:Exception
    {
        public UserDefinedException(string msg):base(msg)
        {

        }
    }

    class no
    {
        static void ValidAge(int age)
        {
            if (age < 18)
            {
                throw new UserDefinedException("age is greater than 18");
            }
            else
            {
                Console.WriteLine("age is accepted");
            }
        }
        public static void Main()
        {
            no ob = new no();
            ValidAge(22);
        }
    }
}
