using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Ques
    {
        public static void Main()
        {
            string[] courses = { "MCA", "MBA", "BCA", "BBA", "BTech", "MTech" };
            Queue<string> que = new Queue<string>(courses);
            que.Enqueue("22");
            que.Enqueue("22");
            que.Enqueue("24");
            que.Enqueue("21");
            que.Enqueue(null);
            que.Dequeue();
            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Peek());
           
            Queue<string> ob = new Queue<string>(que.ToArray());
            foreach(string s in ob)
            {
                Console.WriteLine(s);
            }
        }
    }
}
