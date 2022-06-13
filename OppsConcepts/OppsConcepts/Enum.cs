using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
  
    internal class Enum
    {
        public enum Days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday

        }
        public static void Main()
        {
            // Days d = 0 or (Days)1;
            Days d = Days.sunday;
            Console.WriteLine(d);
        }
    }
}
