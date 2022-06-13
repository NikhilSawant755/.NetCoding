using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Loops
{
    internal class DoWhile
    {

        public static void Main()

        { int counter = 0;
            do
            {
                counter++;

                string result = counter % 2 == 0 ? counter + "even" : counter + "odd"; 
               
                Console.WriteLine(result);
            } while (counter <10);
        }
        }
    
}
