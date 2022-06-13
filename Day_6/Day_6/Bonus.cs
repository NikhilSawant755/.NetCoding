using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Bonus
    {
		public static void Main4()
		{
			double salary, time, bonus;
			Console.WriteLine("Enter Salary");
			salary = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Time period of service of Employee");
			time = Convert.ToInt32(Console.ReadLine());

			if (time > 10)
			{
				bonus = (salary * 0.1) + salary;
				Console.WriteLine("Net salary including bonus =" + bonus);
			}
			else if (time >= 6 && time <= 10)
			{
				bonus = (salary * 0.08) + salary;
				Console.WriteLine("Net salary including bonus =" + bonus);
			}
			else if (time < 6)
			{
				bonus = (salary * 0.05) + salary;
				Console.WriteLine("Net salary including bonus =" + bonus);
			}
		}
	}
}
