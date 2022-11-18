using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
               PrintchBetweentwochars(start,end);
        }

         static void PrintchBetweentwochars(char start, char end)
        {
            if (start.CompareTo(end) < 0)
            {

               for (int i = start+1; i <end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
           {
                for (int i = end+1; i <start; i++)
                {
                    Console.Write((char)i + " ");
                }
                
            }
        }
    }
}
