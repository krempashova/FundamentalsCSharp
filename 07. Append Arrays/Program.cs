using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            // 123|456| 78 => 123456 78

            List<int> NUM = new List<int>();

            string reverseDArrayAstext = "";
            numbers.Reverse();         // 78456123

            foreach (string number in numbers)
            {
                reverseDArrayAstext += number + " ";
            }

            NUM= reverseDArrayAstext.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ', NUM));
        }
    }

        
        
        
    }

