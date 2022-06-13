using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class ReverseArray
    {
       // 5.	WAP to print reverse of an array.Also print every alternate element backwards.
        public static void Main()
        {
            int [] no= { 25, 11, 7, 75, 56 ,2};
            int leng = no.Length;
            for(int i = leng-1; i >=0; i--)
            {
                Console.WriteLine(no[i]);
            }
        }
    }
}
