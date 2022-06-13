using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Overloading
    {
    public void main(int no1)
        {
            Console.WriteLine(no1);
        }
        public void main(string no)
        {
            Console.WriteLine(no);
        }
        public static void Main44() {
            Overloading ob = new Overloading();
            ob.main(2);
        }
    }
}
