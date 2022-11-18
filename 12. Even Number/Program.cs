using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num % 2 != 0)
            {

               
                Console.WriteLine("Please write an even number.");
                int nextnum = int.Parse(Console.ReadLine());
                num = nextnum;

            }

            if (num % 2 == 0)
                num = Math.Abs(num);
            {
                Console.WriteLine($"The number is: {num}");
               
            }

                

        }
    }
}
