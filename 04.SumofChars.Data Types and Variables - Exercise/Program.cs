using System;

namespace _04.SumofChars.Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            for (int i = 0; i <n; i++)
            {
                char CurrentCh = char.Parse(Console.ReadLine());

                sumOfChars += CurrentCh;
            }

            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
