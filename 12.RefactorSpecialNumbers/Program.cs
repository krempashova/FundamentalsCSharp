using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int twin = 0;
            bool isSpecial = false;
            for (int ch = 1; ch <= num; ch++)
            {
                twin = ch;
                while (ch > 0)
                {
                    sumDigits += ch % 10;
                    ch = ch / 10;
                }
                isSpecial  = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", twin, isSpecial);
                sumDigits = 0;
                ch = twin;
            }




        }
    }
}
