using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class LinkedL
    {
        public static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("nikhil"); 
            list.AddLast("nikhil4");
            list.AddLast("nikhil5");
           
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
