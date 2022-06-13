using System;


namespace RevisionProgram
{
    internal class palindromString
    {
        public static void Main()
        {
            string name = "ma2dam";
            string na="";
            for(int i = name.Length-1; i >=0; i--)
            {
                na += name[i];
            }
            if (name == na)
            {
                Console.WriteLine("palindrom string");
            }
            else
            {
                Console.WriteLine("not palindrom string");
            }
        }
    }
}
