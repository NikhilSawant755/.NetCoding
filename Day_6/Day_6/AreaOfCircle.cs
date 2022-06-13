using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class AreaOfCircle
    {

			public static void Main5()
			{
				int r;
				Console.WriteLine("Enter value radius of circle");
				r = Convert.ToInt32(Console.ReadLine());


				Console.WriteLine("Area of circle =  " + (3.14 * r * r));
			}
		
	}
}
