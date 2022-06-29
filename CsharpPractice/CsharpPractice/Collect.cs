using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Collect
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("nikhjil");
            list.Add("sham");
            list.Add("bik");
            list.Add("njj");
            list.Add("njj");
            list.Remove("bik");
            list.RemoveAt(0);
            foreach(string items in list)
            {
                Console.WriteLine(items);
            }


            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(12, "nikhil");
            dict.Add(2, "sham");
            dict.Add(31, "sjik");
            dict.Add(4, "sjik");
            dict.Remove(4);

            foreach(KeyValuePair<int,string> itms in dict)
            {
                Console.WriteLine(itms.Key + "  " + itms.Value);
            }

            Queue<string> que = new Queue<string>();
            que.Enqueue("sham");
            que.Enqueue("shamu");
            que.Enqueue("sh");
            Console.WriteLine(que.Dequeue());
            foreach(string itms in que)
            {
                Console.WriteLine(itms);
            }
            Console.WriteLine("************");
            Stack<string> stack = new Stack<string>();
            stack.Push("sha");
            stack.Push("Nh");
            stack.Push("ik");
            stack.Push("bj");
            
            Console.WriteLine(stack.Contains("bj"));
            foreach(string itms in stack)
            {
                Console.WriteLine(itms);
            }

            SortedSet<string> set = new SortedSet<string>();
            set.Add("jh");
            set.Add("hgb");
            set.Add("jh");

            foreach (string itms in stack)
            {
                Console.WriteLine(itms);
            }

            SortedList<string, string> op = new SortedList<string, string>();
            op.Add("1", "vn");
            op.Add("2","jh");
            op.Add("3","hgb");
            op.Add("4","jh");

            foreach (KeyValuePair<string,string> itms in op)
            {
                Console.WriteLine(itms.Key+" "+itms.Value);
            }
          
            LinkedList<object> my_list = new LinkedList<object>();
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");


            foreach (object obj in my_list)
            {
                Console.WriteLine(obj);
            }
        }

    }
    
}
