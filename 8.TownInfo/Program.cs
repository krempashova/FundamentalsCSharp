using System;

namespace _8.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {Town} has population of {population} and area {area} square km.");
        }
    }
}
