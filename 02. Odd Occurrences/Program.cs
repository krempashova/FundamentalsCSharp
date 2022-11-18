using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02._Odd_Occurrences
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine() //Java C# PHP PHP JAVA C java
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string,int> counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordsInsensitivecase = word.ToLower();
                if(!counts.ContainsKey(wordsInsensitivecase))
                {
                    counts[wordsInsensitivecase] = 0;
                }
                counts[wordsInsensitivecase]++;
            }
            foreach (var count in counts)
            {
                if(count.Value%2!=0)
                {
                    Console.Write(count.Key + " " );
                }
            }
        }
    }
}
