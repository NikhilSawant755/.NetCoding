using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Enum2
    {
        public enum Days
        {
            sunday,monday,tuesday,wednesday,thrusday,friday,saturday
        }

        public static void Main()
        {
            Days ob = (Days)2;
            Console.WriteLine(ob);
        }
    }
}
