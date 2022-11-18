namespace _02._Big_Factorial
{
    using System;
    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;


            }

            Console.WriteLine(factoriel);

        }
    }
}
