using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> wordsandSynonims = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();//CUTE
                string currentsynonims = Console.ReadLine();//ADORABLE
                if(!wordsandSynonims.ContainsKey(currentWord))
                {
                    wordsandSynonims.Add(currentWord, new List<string>());
                }

                wordsandSynonims[currentWord].Add(currentsynonims);
            }

            foreach (var word in wordsandSynonims)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", " ,word.Value)}");
            }
        }
    }
}
