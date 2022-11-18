using System;
using System.Linq;

namespace _03._Rounding_Numbers.Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split( ).Select(double.Parse)
                .ToArray();
          int[] roundedNum=new int [numbers.Length];    
            for (int i = 0; i < roundedNum.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNum[i]}");
            }

        }
    }
}
