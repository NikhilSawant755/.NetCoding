using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    internal class sortString
    {
        public static void Main()
        {
            string[] name = { "pik", "sham", "ram", "bhim","dinesh","simba","raju","ajit","kim","mahesh" };
            string temp = " ";
            
            for(int i = 0; i < name.Length-1; i++)
            {
                for (int j = i+1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j])>0)
                    {
                        temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                    }
                }
            }
          Console.WriteLine(temp);
        }
    }
}
