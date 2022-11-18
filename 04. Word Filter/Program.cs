using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);//kiwi orange banana apple

            Dictionary<string, int> evenwords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if(word.Length%2==0)
                {
                    evenwords.Add(word, 0);
                }
            }
            foreach (var item in evenwords)
            {
                Console.WriteLine($"{item.Key}");
            }
        }
    }
}
