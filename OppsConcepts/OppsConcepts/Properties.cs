using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Properties
    {
        int no ;
        String name;

        public int No
        {
            get => no;set => no = value;
        }
        public string Name
        {
            get => name;set => name = value;
        }
       
        public static void Main()
        {
            Properties ob = new Properties();
            ob.No=100;
            ob.Name = "nik";
            Console.WriteLine(ob.No);

        }
    }
}
