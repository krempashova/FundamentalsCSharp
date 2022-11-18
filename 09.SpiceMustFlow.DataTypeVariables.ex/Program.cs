using System;

namespace _09.SpiceMustFlow.DataTypeVariables.ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int totalAmount = 0;
            int worksConsume = 0;

            while(startingYield>=100)
            {
                daysCount++;
                worksConsume = startingYield - 26;
                totalAmount += worksConsume;
                startingYield -= 10;
            }
            if(totalAmount>=26)
            {
                totalAmount -= 26;
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalAmount);
        }
    }
}
