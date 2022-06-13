using System;


namespace Day14Loops
{
    internal class WhileLoops
    {
        public static void Main4()
        {


            int counter = 0;

            /* while( counter<=10){
                 counter++;
                 if (counter % 2 == 0)
                 {
                     Console.WriteLine(counter);
                 }
             }*/
            while (counter<10)
            {
                counter++;
              string result=  counter % 2 == 0 ? counter + "even" : counter + "odd";
                Console.WriteLine(result);
              
            }
           
        }
    }
}
