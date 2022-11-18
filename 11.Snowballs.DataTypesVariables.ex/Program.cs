
using System.Numerics;

using System;


namespace _11.Snowballs.DataTypesVariables.ex
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSnowBalls = int.Parse(Console.ReadLine());
            BigInteger MaxValue = BigInteger.MinusOne;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            for (int i = 1; i <= numSnowBalls; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallvalue = BigInteger.Pow((snowBallSnow / snowBallTime),snowballQuality);
                if (snowBallvalue > MaxValue)
                {
                    MaxValue = snowBallvalue;
                    maxSnow = snowBallSnow;
                    maxTime = snowBallTime;
                    maxQuality = snowballQuality;
                }

            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {MaxValue} ({maxQuality})");
        


        }
    }
}
