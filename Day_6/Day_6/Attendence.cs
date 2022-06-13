using System;

namespace Day_6
{
     class Attendence
    {
		public static void Main4()
		{
			double attended, workingDay, avg;
			Console.WriteLine("Enter the attended lecture");
			attended = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Out of lecture");
			workingDay = Convert.ToInt32(Console.ReadLine());

			avg = (attended / workingDay);

			if (avg <= 0.75)
			{
				Console.WriteLine("Student will not able to Sit in Exam" + avg);
			}
			else
			{
				Console.WriteLine("student is allowed to sit in exam");
			}

		}
	}
}
