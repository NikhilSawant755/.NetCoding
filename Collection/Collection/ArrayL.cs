using System.Collections;

namespace Collection
{
    internal class ArrayL
    {
        public static void Main()
        {
            ArrayList ob = new ArrayList();
            ob.Add(100);
            ob.Add("ram");
            ob.Add(10);
            ob.Add("nikj");
            ob.Add(1);
            ob.Add("nik");
            ob.Insert(1, "mik");
            ob.Remove(100);
            foreach(dynamic A in ob)
            {
                Console.WriteLine(A);
            }
        }
    }
}
