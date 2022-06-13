using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExceptionHandling
{
    internal class ArrayLists
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("nikhil");
            list.Add("shubham");     // for Add element
            list.Add("ramesh");
            list.Add("Dinesh");
            

            list.Insert(1,"nik");  // poistion then name
            list.Remove("nikhil");

           
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);// for count

            list.Sort();
            foreach(var ob in list)
            {
                Console.WriteLine(ob ) ;
            }
           
        }
    }

  
}
