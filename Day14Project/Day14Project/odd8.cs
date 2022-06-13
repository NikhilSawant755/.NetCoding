

namespace Day14Project
{
    internal class odd8
    {
        public static void Main()
        {
            int[] no = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Element ");
                no[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pos = 10;
            int element = 2;
            for (int i = no.Length - 1; i >pos - 1; i--)
            {
                no[i] = no[i +1];
            }
            no[pos - 1] = element;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(no[i]);
            }

        }
    }
}
