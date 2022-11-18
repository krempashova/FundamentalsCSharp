using System;
using System.Linq;
using System.Collections.Generic;



namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             List <int> firstcolection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondcolection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List <int>();
                int n = Math.Min(firstcolection.Count, secondcolection.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(firstcolection[i]);
                result.Add(secondcolection[i]);

            }

            if(firstcolection.Count>secondcolection.Count)
            {
                for (int i = n; i < firstcolection.Count; i++)
                {
                    result.Add(firstcolection[i]);
                }
            }
            else if(secondcolection.Count>firstcolection.Count)
            {
                for (int i = n; i < secondcolection.Count; i++)
                {
                    result.Add(secondcolection[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
            }
        }
    }

    

