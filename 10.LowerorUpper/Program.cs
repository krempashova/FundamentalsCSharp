using System;

namespace _10.LowerorUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dul = 0, sh=0, V = 0;

            Console.WriteLine("Length: ");

            dul = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            sh = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            V = double.Parse(Console.ReadLine());

            V = (dul + sh + V) / 3;

            Console.WriteLine($"Pyramid Volume: {V:f2}");





        }
    }
}
