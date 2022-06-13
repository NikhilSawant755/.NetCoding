using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class DivisibleBy5
    {
       
            public static void Main4()
            {
                int num;
                Console.WriteLine("Enter the num");
                num = Convert.ToInt32(Console.ReadLine());


                if (num % 5 == 0 && num % 11 == 0)
                {
                    Console.WriteLine("number is divisible by 5 & 11");

                }
                else
                {
                    Console.WriteLine("number is Not divisible by 5 & 11");
                }
            }
        }
    }

