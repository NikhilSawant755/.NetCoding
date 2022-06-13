using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class HashTab
    {
        public static void Main()
        {
            Hashtable ob = new Hashtable();
            ob.Add("name", "nikhil");
            ob.Add("emil", "Sawant@123");
            ob.Add("MobNo", 9970236362);
            ob.Add("Place", "Satara");
            ob.Add("country", "India");
            Console.WriteLine(ob["name"]);
            ob["name"] = "sham";
            foreach(object key  in ob.Keys)
            {
                Console.WriteLine(key+" "+ob[key]);
            }

            Hashtable ob2 = new Hashtable();
            ob2.Add(11, "nikhil");
            ob2.Add(2, "Sham");
            ob2.Add(3, "Ram");

            foreach(object key in ob2.Keys)
            {
                Console.WriteLine(key + "==>"+ob2[key]);
            }

        }
    }
}
