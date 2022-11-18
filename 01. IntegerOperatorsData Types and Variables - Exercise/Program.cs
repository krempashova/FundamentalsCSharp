using System;

namespace _01._IntegerOperatorsData_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3=int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            long firstRezult = num1 + num2;
            long secondRezult = firstRezult / num3;
            long thyrdRezult = secondRezult * num4;
            Console.WriteLine(thyrdRezult);



        }
    }
}
