using System;

namespace _4._Print_and_Sum_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum=int.Parse(Console.ReadLine());
            int endNum=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNum; i <= endNum; i++)
            { 
                sum += i;
                Console.Write($"{i} ");
                


            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
