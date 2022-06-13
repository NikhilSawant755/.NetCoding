using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Assignment
    {

        public static void Main()
        {
            List<object> ob = new List<object>();
            ob.Add("sham");
            ob.Add("ram");
            ob.Add("km");
            ob.Add("nj");
            ob.Sort();
            foreach (dynamic k in ob)
            {
                Console.WriteLine(k);
            }
        }
    }
    class Employe
    {
        string name;
        string designation;
        int salary;

        public Employe(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"Name:{name} designation:{designation} salary:{salary}"; ;
        }
        public static void Main()
        {
            List<Employe> ob = new List<Employe>();
            ob.Add(new Employe("nik", "BTech", 200));
            ob.Add(new Employe("ram", "MTech", 300));
            ob.Add(new Employe("sham", "MD", 400));

            foreach (dynamic k in ob)
            {
                Console.WriteLine(k);
            }
        }
    }
    class Colors
    {
        public static void Main()
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("red");
            que.Enqueue("black");
            que.Enqueue("green");
            que.Enqueue("black"); //allow
            foreach (dynamic k in que)
            {
                Console.WriteLine(k);
            }
        }
    }
    class Sort
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> ob = new SortedList<int, string>();
            ob.Add(25, "nikil");
            ob.Add(3, null);
            ob.Add(1, "sham");
            ob.Add(11, "pam");



            foreach (KeyValuePair<int, string> kvp in ob)
            {
                Console.WriteLine(kvp.Key + "==>" + kvp.Value);
            }

        }
    }

    class dict
    {
      
        public static void Main(string[] args)
        {
            Dictionary<string, float> ob = new Dictionary<string, float>();
            ob.Add("ram", 2);
            ob.Add("sam", 12);
            ob.Add("nlm", 2);

            foreach (KeyValuePair < string,float> k in ob){
                Console.WriteLine("Key: {0}, Value: {1}", k.Key, k.Value);
            }
        }
    }
    class StackPgm
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Avangers");
            stack.Push("Gladiator");
            stack.Push("The Godfather");
            stack.Push("The shawshank Redemption");
            stack.Push("Avatar");

            Console.WriteLine("Before deleting element from stack ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //delete from stack
            stack.Pop();

            Console.WriteLine("\nAfter deleting element from stack ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
     class Employee1 : IComparable<Employee1>
    {
        string name;
        string designation;
        int salary;

        public Employee1(string name, string designation, int salary)
        {
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int CompareTo(Employee1? other)
        {

            return other.salary.CompareTo(this.salary);
            /*if(this.salary==other.Salary)
            {
                return this.name.CompareTo(other.name);
            }
            else
            {
                return this.salary.CompareTo(other.salary);
            }*/
        }

        public override string ToString()
        {
            return $"{name}, {designation}, {salary}";
        }

    }
    class EmployeeSortedList_DescOrder
    {
        static void Main(string[] args)
        {
            SortedList<Employee1, string> sl = new SortedList<Employee1, string>();
            sl.Add(new Employee1("Sham", "Programmer", 10000), "Testing");
            sl.Add(new Employee1("Sam", "Admin", 20000), "Developement");
            sl.Add(new Employee1("John", "Analyst", 25000), "Testing");
            sl.Add(new Employee1("aditya", "Hr", 5000), "HR");
            foreach (KeyValuePair<Employee1, string> k in sl)
            {
                Console.WriteLine(k.Key + "==>" + k.Value);
            }
        }
    }

}
