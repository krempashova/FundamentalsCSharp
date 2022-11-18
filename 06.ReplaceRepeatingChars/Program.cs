using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //aaaaabbbbbcdddeeeedssaa
            string text = Console.ReadLine();
            char previouschar = text[0];
            Console.Write(previouschar);
            for (int i = 1; i < text.Length; i++)
            {
                char currenChar = text[i];
               
                
                if(currenChar!=previouschar)
                {
                    previouschar = currenChar;
                    Console.Write(previouschar);

                }

            }



        }
    }
}
