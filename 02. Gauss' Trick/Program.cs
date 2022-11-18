using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5
            List<int>numbers=Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                int sumNumbers = numbers[i] + numbers[numbers.Count - 1-i];
                result.Add(sumNumbers);
            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.Write(String.Join(" ",result));
        }
    }
}
