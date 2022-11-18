using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal foodKg = decimal.Parse(Console.ReadLine());
            decimal heyKg = decimal.Parse(Console.ReadLine());
            decimal coverKg = decimal.Parse(Console.ReadLine());
            decimal pigWeigh = decimal.Parse(Console.ReadLine());
            //300gr=0.3kg
            for (int i = 1; i <= 30; i++)
            {
                foodKg -= 0.3m;
                if(i%2==0)
                {
                    heyKg -= (foodKg * 0.05m);
                }
                if(i%3==0)
                {
                    coverKg -= (pigWeigh / 3);
                }
                if(foodKg<=0||heyKg<=0||coverKg<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! " +
                $"Puppy is happy! " +
                $"Food: {foodKg:f2}, Hay: {heyKg:f2}, Cover: {coverKg:f2}.");
        }
    }
}
