using System;
using System.Linq;

namespace _1._Train.Аrrays.ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numWagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] people = new int[numWagons];
            for (int i = 0; i < numWagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];

            }

            Console.Write(string.Join(" ", people));
            Console.WriteLine();
            Console.WriteLine(sum);




        }
    }
}
