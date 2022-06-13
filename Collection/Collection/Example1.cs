using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Example1
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            Console.WriteLine(list[0]);



            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(10, "nk");
            dict.Add(11, "Skf");

            Console.WriteLine(dict.ContainsKey(25));
            Console.WriteLine(dict.ContainsValue("skf"));
            dict[10] = "sham";
            dict.Clear();
            dict.Remove(11);

            foreach (KeyValuePair<int, string> k in dict)
            {
                Console.WriteLine(k.Key + "=>" + k.Value);
            }

            foreach (int a in dict.Keys)
            {
                Console.WriteLine(a + "=>" + dict[a]);
            }

            Stack<string> st = new Stack<string>();
            st.Push("mik");
            st.Push("nik");

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());

            foreach (string i in st)
            {
                Console.WriteLine(i);
            }

            Queue<double> q = new Queue<double>();
            q.Enqueue(9.4);
            q.Enqueue(7.5);
            Console.WriteLine(q.Dequeue());//9.4

        }
    }

    class AList
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(50);
            list.AddLast(510);
            list.AddLast(540);
            list.AddFirst(450);

            Console.WriteLine(list.Remove(50));

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            LinkedListNode<int> n1 = list.Find(50);
            list.AddAfter(n1, 900);
            list.Remove(50);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }



        }
    }

    class NSet
    {
        public static void Main(string[] args)
        {
            //key unique
            //sorted on keys not values

            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Aditya", 52);
            ss.Add("shubham", 52);
            ss.Add("prasad", 52);
            ss.Add("Ram", 52);

            foreach (KeyValuePair<string, int> k in ss)
            {
                Console.WriteLine(k.Key + "===>" + k.Value);
            }
        }
    }

    class Stud : IComparable<Stud>
    {
        int sid;
        string nm;
        int percentage;

        public Stud(int sid, string nm, int percentage)
        {
            this.Sid = sid;
            this.Nm = nm;
            this.Percentage = percentage;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Nm { get => nm; set => nm = value; }
        public int Percentage { get => percentage; set => percentage = value; }



        public int CompareTo(Stud? other)
        {
            /* if (this.percentage > other.percentage)
             {
                 return 1;
             }else if (this.percentage < other.percentage)
             {
                 return -1;
             }
             else
             {
                 return 0;
             }*/
            if (this.percentage > other.percentage)
            {
                return this.nm.CompareTo(other.nm);
            }
            else
            {
                return this.percentage.CompareTo(other.percentage);
            }
        }
    }
   
    class k
    {
        public static void Main(string[] args)
        {
            SortedList<Stud, string> ss = new SortedList<Stud, string>();
            ss.Add(new Stud(1, "uddhav", 93), "java");
            ss.Add(new Stud(2, "uddhav", 94), "j");
            ss.Add(new Stud(2, "uddhav", 98), "java");

            foreach (KeyValuePair<Stud, string> k in ss)
            {
                Console.WriteLine(k.Key + "==>" + k.Value);
            }
        }
    }
}

