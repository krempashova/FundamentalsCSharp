using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            PrintDivideResult(firstNum, secondNum);
        }

        static void PrintDivideResult(int firtNum, int secondNum)
        {

            double fact1 = 1;
            for (int i = firtNum; i > 0; i--)
            {


                fact1 = fact1 * i;
            }


            double fact2 = 1;
            for (int i = secondNum; i > 0; i--)
            {


                fact2 = fact2 * i;

            }
            double divideResult = (fact1) / fact2;
            Console.WriteLine($"{divideResult:f2}");
        }
        }
}
