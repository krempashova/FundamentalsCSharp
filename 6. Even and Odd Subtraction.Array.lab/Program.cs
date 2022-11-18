using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction.Array.lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OddSum = 0;
            int EvenSum = 0;

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] %2==0)
                {
                    EvenSum += array[i];
                }
                else
                {
                    OddSum += array[i];
                }
            }
            int result = EvenSum - OddSum;
            
            Console.WriteLine(result);



        }
    }
}
