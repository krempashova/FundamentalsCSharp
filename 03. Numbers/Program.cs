using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         List<int>numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)  //10 20 30 40 50
                .Select(int.Parse)
                .ToList();
            List<int> topNumbers = new List<int>();
            //1 find avergae value;
            double averagenumbers=numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]>averagenumbers)
                {
                    topNumbers = numbers.OrderByDescending(x => x)
                    .Where(topNumbers => topNumbers > averagenumbers)
                    .ToList();
                       
                    
                }
            }
            if(topNumbers.Count>5)
            {
                Console.WriteLine(string.Join(" ", topNumbers.Take(5)));
            }
            else if(topNumbers.Count==0)
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine(string.Join(" ", topNumbers));
                
            }
                    
        }
    }
}
