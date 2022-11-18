using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //hi ABC WORK
            foreach (var currentword in words)
            {
                for (int i = 0; i < currentword.Length; i++)
                {
                   result+= currentword;
                   
                }
               
            }
            Console.WriteLine(result);



        }
    }
}
