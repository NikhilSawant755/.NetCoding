using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ListA
    {
        public static void Main(string[] args)
        {
            List<string> ob = new List<string>();
            ob.Add("nikhil");
            ob.Add("sham");
            ob.Add("ram");
            ob.Add("aditya");
            ob.Add("priya");
            ob.Add("radhika");
            ob.Remove("ram");
            ob.Insert(1, "sea");
            ob.Sort();
            Console.WriteLine(ob.Contains("nikhil"));
            Console.WriteLine(ob[0]);
            foreach (string itms in ob)
            {
                Console.WriteLine(itms);
            }
      
        }
    }

   
    class student:IComparable<student>
    {
        int id;
        string name;

        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public int CompareTo(student other)
        {
            if (this.id > other.id)

                return 1;
            else if (this.id < other.id)
                return -1;
            else
                return 0;
        }
    }
    class ListB
    {
        public static void Main()
        {
            List<student> ob = new List<student>();
            student ob2 = new student(101,"nk");
            student ob3 = new student(12, "sk");
            student ob4 = new student(13, "pk");

            List<student> ob1 = new List<student> { ob2,ob3,ob4};
            
                ob1.Sort();
            foreach (student s in ob1)
            {
                Console.WriteLine(s.Id +"==>"+s.Name);
            }





        }

    }
}
