using System;

namespace P04.Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            string reversedInput = string.Empty;
            for (int i=input.Length-1; i >= 0; i--)
            {
                char currenCh = input[i];
                reversedInput += currenCh;
                Console.Write(currenCh);
            }
        }
    }
}
