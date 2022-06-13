using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgram
{
    internal class CoPrime
    {
		public static void Main(string[] args)
		{

			int a = 18;
			int b = 12;

			int c = 0;
			for (int divider = 1; divider <= a && divider <= b; divider++)
			{
				if (a % divider == 0 && b % divider == 0)
				{
					c++;
				}
			}
			if (c == 1)
				Console.WriteLine("Co prime");
          
		}
	}
}
