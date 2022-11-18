using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//123
            
            FindPalidromeInt(input);
            while (input != "END")
            {
                bool IsPalidrome = FindPalidromeInt(input);
               if(IsPalidrome)
                {
                    Console.WriteLine("true");
                }
               else
                {
                    Console.WriteLine("false");
                }
               input = Console.ReadLine();  

            }
        }

      static bool FindPalidromeInt(string input)
        {
            string reversedInput = "";
            for (int i = input.Length-1 ;i >= 0; i--)
            {
                reversedInput += input[i];
            }
            if(reversedInput==input)
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }
    } 
}
Sys