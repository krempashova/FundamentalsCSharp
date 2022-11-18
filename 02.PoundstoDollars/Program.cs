using System;

namespace _02.PoundstoDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPound = double.Parse(Console.ReadLine());

            double usdolars = britishPound * 1.31;
            Console.WriteLine($"{usdolars:f3}");


        }
    }
}
