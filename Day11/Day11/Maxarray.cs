using System;


namespace Day11
{
    internal class Maxarray
    {
        public static void Main()
        {
           
            int [] ara = { 10, 15, 45, 85 };
            int temp;
            for (int i=0; i>=ara.Length;i++){
               for(int j = i + 1; i >= ara.Length; j++)
                {
                    if (ara[i] > ara[j])
                    {
                        temp = ara[i];
                        ara[i] = ara[j];
                        ara[j] = temp;
                    }
                }
                

            }
            Console.WriteLine(ara[ara.Length - 1]);
        }
    }
}
