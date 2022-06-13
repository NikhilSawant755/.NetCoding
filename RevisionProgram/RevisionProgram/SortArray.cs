using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class SortArray
    {
        public static void Main()
        {
            int[] no = { 15, 8, 95, 785, 64 };
            int temp=0;
            for (int i = 0; i < no.Length; i++)
            {
                for (int j = i+1; j < no.Length; j++)
                { 
                    if (no[i] > no[j]) { 
                    temp = no[i];
                    no[i] = no[j];
                    no[j] = temp;
                    }

                }
                Console.WriteLine(no[i]);
            }
          
        }  
      
    }
}
