namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();

            string comand = Console.ReadLine();//text

            for (int i = 0; i < comand.Length; i++)
            {
                char currChar = comand[i];
                if (currChar != ' ')
                {
                    if (!countChars.ContainsKey(currChar))
                    {
                        countChars[currChar] = 0;
                    }
                    countChars[currChar]++;
                }
            }


            foreach (var kvp in countChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


        }
    }
}