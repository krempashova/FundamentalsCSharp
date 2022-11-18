using System;

namespace _02.SumDigitsData_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int twinNum = num;
            int sumDigits = 0;
            int lastDigit = twinNum % 10;
            while(twinNum>0)
                
            {
                sumDigits += lastDigit;
                twinNum /= 10;
                lastDigit=twinNum % 10;
               

            }
            Console.WriteLine(sumDigits);
        }
    }
}
