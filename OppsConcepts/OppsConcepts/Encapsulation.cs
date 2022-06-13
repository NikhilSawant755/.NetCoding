using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Encapsulation
    {
       private String _name;
        private int _no;

       public string name
        {
            get => name;set => name = value;
        }
        public int no
        {
            get => no;set => no = value;
        }

        public static void Main()
        {
            

        }
    }
}
