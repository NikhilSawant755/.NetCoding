using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dict
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> ob = new Dictionary<string, string>();
            ob.Add("aij", "nikhil");
            ob.Add("hu", "ham");
            ob.Add("mkjh", "Ram");
          

            
            foreach(KeyValuePair<string,string> v in ob)
            {
                Console.WriteLine(v.Key+"===>"+v.Value);
            }

            
        }
    }

    class A
    {
        public static void Main(string[]args)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("name", "nikhil");
            dict.Add("emil", "Sawant@123");
            dict.Add("MobNo", 9970236362);
            dict.Add("Place", "Satara");
            dict.Add("country", "India");

            foreach(KeyValuePair<string,object> ob in dict)
            {
                Console.WriteLine(ob.Key + "===>"+ob.Value);
                Console.ReadLine();
            }
        }
    }
    class Customer{
        int RollNo;
        String name;
        String City;

        public int RollNo1 { get => RollNo; set => RollNo = value; }
        public string Name { get => name; set => name = value; }
        public string City1 { get => City; set => City = value; }

        public Customer(int rollNo, string name,string City)
        {
            this.RollNo1 = rollNo;
            this.City1 = City;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"id:{RollNo} Name:{name} city1:{City}";
        }
        }
    class p { 
        public static void Main(string[]args) { 
    Dictionary<int, Customer> dict2 = new Dictionary<int, Customer>();
            dict2.Add(1, new Customer(12, "Nikhil", "nj"));
            dict2.Add(1, new Customer(13, "Swapnil", "nj"));
            dict2.Add(3, new Customer(14, "Aditya", "nj"));
            dict2.Add(4, new Customer(15, "Prasad", "nj"));
            foreach (Customer ob in dict2.Values)
            {
                Console.WriteLine(ob.Name + " " + ob.RollNo1 + " " + ob.City1);
            }
            foreach(KeyValuePair<int, Customer> ob in dict2)
            {
                Console.WriteLine("Key: {0}, Value: {1}", ob.Key,ob.Value);
            }

        }
    }
}
