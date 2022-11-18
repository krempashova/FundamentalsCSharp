using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool strongNum = true;
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int symOFdigits = 0;
                int digit = num;
                while(digit>0)
                {
                    symOFdigits += digit % 10;
                    digit /= 10;
                }
                if(symOFdigits == 5 || symOFdigits==7 || symOFdigits==11)
                {
                    strongNum = true;
                }
                else
                {
                    strongNum = false;
                }
                Console.WriteLine($"{num} -> {strongNum}");
            }


            
            
        }
    }
}
