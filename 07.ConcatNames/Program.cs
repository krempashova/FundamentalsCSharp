using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter=Console.ReadLine();
            Console.WriteLine($"{FirstName}{delimiter}{lastName}");




        }
    }
}
