using System;

namespace P06Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int copyInteger = integer;
            int sumfactorials = 1;
            int lastDigit =copyInteger%10;
            int totalsum = 0;
            while (copyInteger>0)
            {

                for (int i = 1; i <= lastDigit; i++)
                {
                    
                    sumfactorials *= i;
                }
                copyInteger /= 10;
                totalsum += sumfactorials;
                sumfactorials = 1;
                lastDigit = copyInteger % 10;
                
            }

                 
            if(totalsum==integer)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
