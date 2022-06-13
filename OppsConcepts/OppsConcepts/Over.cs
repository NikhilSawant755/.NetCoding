using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{

    public class Employee
    {
        string name;
        int rollNo;

        public string Name
        {
            get => name; set => name = value;
        }
        public int RollNo
        {
            get => rollNo; set => rollNo = value;
        }
    }

    internal class Over
    {
        public static void Main(string[] args)
        {
            Employee ob = new Employee();
            ob.Name = "nik";
            ob.RollNo = 10;
            Console.WriteLine(ob.Name);
            Console.WriteLine(ob.RollNo);


        }
    }
}  
