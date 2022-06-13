using System;


namespace stringFun
{
   class ViseVersa
    {
       static void ReplChar()
        {
            string s = "NIkhIl";
            int n = s.Length;
            char cha;
            for(int i = 0; i < n; i++)
            {
                cha= s[i];
                if (char.IsUpper(cha))
                {
                    Console.WriteLine(char.ToLower(cha));
                }else if (char.IsLower(cha))
                {
                    Console.WriteLine(char.ToUpper(cha));
                }
            }

        }

        public static void Main44()
        {


            ViseVersa.ReplChar();
     
           


        }
    }
}
