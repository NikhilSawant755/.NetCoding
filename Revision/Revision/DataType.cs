using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{

    internal class DataType
    {
        int n1 = 10;
        int n2 = 5;
     
        
        public void Same( int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
        public void Game( ref string name)
        {
            Console.WriteLine("niik"+name);
        }
        public static void Main44()
        {
          
            string name = "sonal";
            DataType ob = new DataType();
            ob.Same(15,20);//value type
            ob.Game(ref name);
        }
    }
}
