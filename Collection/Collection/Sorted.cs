using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Sorted
    {
        public static void Main(string[] args)
        {
            SortedList<int,string> ob = new SortedList<int,string>();
            ob.Add(25, "nikil");
            ob.Add(3, null);
            ob.Add(1, "sham");
            ob.Add(11, "pam");
            


            foreach (KeyValuePair<int, string> kvp in ob)
            {
                Console.WriteLine(kvp.Key+"==>"+kvp.Value);
            }

            List<string> list = ob.Values.ToList();

            foreach (string o in list)
            {
                Console.WriteLine(o);
            }
            
        }
    }
}
