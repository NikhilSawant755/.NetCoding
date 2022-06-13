using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class NameOfMnth
    {
		public static void Main4()
		{
			int no;
			Console.WriteLine("Enter number");
			no = Convert.ToInt32(Console.ReadLine());

			if (no == 1)
			{
				Console.WriteLine(" January");
			}
			else if (no == 2)
			{
				Console.WriteLine(" February");
			}
			else if (no == 3)
			{
				Console.WriteLine("March");
			}
			else if (no == 4)
			{
				Console.WriteLine("April");
			}
			else if (no == 5)
			{
				Console.WriteLine("May");
			}
			else if (no == 6)
			{
				Console.WriteLine("Jun");
			}
			else if (no == 7)
			{
				Console.WriteLine("July");
			}
			else if (no == 8)
			{
				Console.WriteLine("August");
			}

			else if (no == 9)
			{
				Console.WriteLine("September");
			}
			else if (no == 10)
			{
				Console.WriteLine("Octomber");
			}
			else if (no == 11)
			{
				Console.WriteLine("November");
			}
			else if (no == 12)
			{
				Console.WriteLine("December");
			}
		}
	}
}
