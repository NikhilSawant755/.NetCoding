using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Hashing
    {
        public static void Main()
        {
            Hashtable ob = new Hashtable();
            ob.Add(9, "aditya");
            ob.Add(10, "Rohan");
            ob.Add(11, "Sham");
            ob.Add(12, "ram");
            ob.Add(13, "Nikhil");
            Console.WriteLine(ob[9]);
            ob.Remove(ob[10]);
            Console.WriteLine(ob.ContainsKey(10));

          
        }
    }
}
