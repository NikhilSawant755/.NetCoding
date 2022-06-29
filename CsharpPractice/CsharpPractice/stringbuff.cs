using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class stringbuff
    {
        public static void Main(string[] args)
        {
            string name = "N  ikhil";
            string name2 = "    nikhi";
            Console.WriteLine(name.Substring(0, 5)); //0to 4 ghet 5 v nay ghet
            Console.WriteLine(name.CompareTo(name2));
            Console.WriteLine(name.ToCharArray());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name2.Trim());
            Console.WriteLine(string.Concat(name, name2));


            StringBuilder ob = new StringBuilder("hello", 50);
            ob.Append("nikhil");
            ob.AppendLine("shan");
            ob.Remove(0, 5);
            Console.WriteLine(ob);
        }
    }



    class student
    {
        int no;
        string name;

        public student(int no, string name)
        {
            this.No = no;
            this.Name = name;
        }

        public int No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }


    }
    class InterNk
    {
        public static void Main(string[] args)
        {
            List<student> stud = new List<student>();
            stud.Add(new student(11, "nikhil"));
            stud.Add(new student(21, "suraj"));
            stud.Add(new student(31, "shubham"));

            stud.Sort();
            foreach (student ob in stud)
            {
                Console.WriteLine(ob.No + "" + ob.Name);
            }
        }

    }


  class Employe:IComparable<Employe>
    {
        int id;
        string Name;
        string Class;
        float marks;

        public Employe(int id, string name, string @class, float marks)
        {
            this.Id = id;
            Name1 = name;
            Class1 = @class;
            this.Marks = marks;
        }

        public int Id { get => id; set => id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Class1 { get => Class; set => Class = value; }
        public float Marks { get => marks; set => marks = value; }

        public int CompareTo(Employe other)
        {
            if (this.marks > other.marks)
            {
                return 1;
            }else if(this.marks< other.marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class CompareCust : IComparer<Employe>
    {
        public int Compare(Employe x, Employe y)
        {
            if (x.Marks > y.Marks)
            {
                return 1;
            }else if (x.Marks < y.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class TestCustomer
    {
        public static void Main(string[]args)
        {
            List<Employe> pl = new List<Employe>();
            pl.Add(new Employe(1,"nikh","btech",75.4F));
            pl.Add(new Employe(15, "kunal", "Comp", 5.4F));
            pl.Add(new Employe(54, "sham", "art", 77.4F));
            pl.Add(new Employe(10, "ram", "be", 25.4F));
           // pl.Sort(obl);
            CompareCust obl = new CompareCust();
            pl.Sort(obl);
            

            foreach(Employe p in pl)
            {
                Console.WriteLine(p.Id + " " + p.Name1 + " " + p.Class1+" "+p.Marks);
            }
        }
    }
}
