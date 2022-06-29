using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class NonGen
    {
        public static void Main(string[]args)
        {
            ArrayList ob = new ArrayList();
            ob.Add(1);
            ob.Add("sh");
            ob.Add(22);
            ob.Add("nikhil");
            ob.Add(100);
            ob.Contains(1);
         
            foreach(object o in ob)
            {
                Console.WriteLine(o);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "nikhil");
            hashtable.Add("10", "Aditya");
            hashtable.Add("14", "raju");
            hashtable.Add("11", "shamu");
            hashtable.Add("18", "nawab");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

        }
    }


  
}
