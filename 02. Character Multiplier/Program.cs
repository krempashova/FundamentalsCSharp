using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Peter George
            string one = text[0];
            string two = text[1];
            FindSumofStrings(one, two);

        }

        private static void FindSumofStrings(string one, string two)
        {

            int totalsum = 0;
          
            int shortstring = Math.Min(one.Length, two.Length);

            for (int i = 0; i < shortstring; i++)
            {
                totalsum += one[i] * two[i];
            }
            string longeststring = one;
            if (longeststring.Length < two.Length)
            {
                longeststring = two;
            }
            for (int i = shortstring; i < longeststring.Length; i++)
            {
                totalsum += longeststring[i];
            }
            Console.WriteLine(totalsum);
        }
    }
}
