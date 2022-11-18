using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] realNums = Console.ReadLine()//8 8 2 5 
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            for (int i = 0; i < realNums.Length; i++)
            { 
                double curnum = realNums[i];

                if (!counts.ContainsKey(curnum))
                {
                    counts[curnum] = 0;
                }
                counts[curnum]++;   
            }
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

