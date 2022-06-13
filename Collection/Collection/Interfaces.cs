using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Interfaces
    {
        int no;
        string name;
        int Salary;

        public Interfaces(int no, string name, int salary)
        {
            this.No = no;
            this.Name = name;
            Salary1 = salary;
        }

        public int No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }
        public int Salary1 { get => Salary; set => Salary = value; }

        public static void Main()
        {

        }
    }
}
