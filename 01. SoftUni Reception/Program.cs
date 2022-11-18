using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int numOfStudenst = int.Parse(Console.ReadLine());

            int studenstForHour = employee1 + employee2 + employee3;
            double neededHOURS = numOfStudenst /(double)studenstForHour;
            double neededHOURSoutbreak =Math.Ceiling(neededHOURS);
            for (int i = 1; i< neededHOURSoutbreak; i++)
            {
                if (i % 3 == 0 && numOfStudenst>0)
                {
                    neededHOURS++;
                }


            }
            Console.WriteLine($"Time needed: {Math.Ceiling(neededHOURS)}h.");

        }
    }
}
