using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class OddEven
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    arr1[j] = arr[i];
                    k++;
                }
                if (arr[i]%2!=0)
                {
                    arr2[k] = arr[i];
                    j++;
                }
            }
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine("even"+ arr1[k]);
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("odd" + arr2[j]);
            }

        }
    }
}
