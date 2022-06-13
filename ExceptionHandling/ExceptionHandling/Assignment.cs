using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class N
    {
        public static void Main() { 
        ArrayList al = new ArrayList();
         al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");

           for(int i = 0; i < al.Count; i++)
            {
                for (int j = i+1; j < al.Count; j++)
                {
                    if (al[i] == al[j])
                    {
                        al.RemoveAt(i);
                        Console.WriteLine(al[j]);
                    }
               
                }
                
            }
         
        }

    }

   
    class Player
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter playerId");
            int playerId = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter playerName");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("Enter Country");
            string Country = Console.ReadLine();
          
            Console.WriteLine("Enter Team");
            string team= Console.ReadLine();


            ArrayList ob = new ArrayList();
            ob.Add(playerId);
            ob.Add(playerName);
            ob.Add(Country);
            ob.Add(team);

            foreach(dynamic s in ob)
            {
                Console.WriteLine(s);
            }
        }
        
    }
  
  class student
    {
        int id;
        string name;
        ArrayList hobbies;

        public student(int id, string name, ArrayList hobbies)
        {
            this.Id = id;
            this.Name = name;
            this.Hobbies = hobbies;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ArrayList Hobbies { get => hobbies; set => hobbies = value; }

        public static void Main(string[] args)
        {

            ArrayList hobbies = new ArrayList();
            hobbies.Add("cricket");
            hobbies.Add("football");

            student ob = new student(11, "nikhil", hobbies);
           
            foreach(dynamic i in ob)
            {
                Console.WriteLine(i);
            }
           
        }
        
            

            
        }

    }
    class nik
    {
    }
    
    internal class Assignment
    {

        public static void Main()
        {
            int no = 10;
            int no2 = 0;

            try
            {

                Console.WriteLine(no / no2);
            }

            catch (DivideByZeroException ex)
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

    class C
    {
        public static void Main()
        {
            string name = null;

            try
            {
                int na = name.Length;
                Console.WriteLine(na);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("child");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("child");
            }
            catch (Exception)
            {
                Console.WriteLine("child");
            }

            finally
            {
                Console.WriteLine("always exicuted");
            }

        }
    }

    class k
    {
        public static void Main()
        {
            int[] no = { 1, 2, 2 };

            try
            {
                Console.WriteLine(no[5]);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("child ");
            }
            catch (Exception e)
            {
                Console.WriteLine("parent");
            }
            finally
            {
                Console.WriteLine("always exicuted");
            }



        }
    }

    class j
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("age is must greater than 18");
            }
            else
            {
                Console.WriteLine("accepted age is greater than 18");
            }

        }
        public static void Main()
        {
            CheckAge(20);
        }

    }

  class s
    {
        
        public static void Main()
        {
            Console.WriteLine("TotalCash");
            int TotalCash = int.Parse(Console.ReadLine());
            Console.WriteLine("WithDraw");
            int WithDraw = int.Parse(Console.ReadLine());
           

            int balance = TotalCash - WithDraw;
            if (balance <= 0)
            {
                throw new BalanceException();

            }
            Console.WriteLine(balance);

          
        }
    }
   class BalanceException : Exception
    {
        string name;

        public BalanceException()
        {
        }

        public BalanceException(string name)
        {
            name = name;

        }
        public override string Message
        {
            get
            {
                return "insufficient Balance";
            }

        }
    }

}
