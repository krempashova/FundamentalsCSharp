using System;

namespace _04.CenturiestoMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int century = int.Parse(Console.ReadLine());
            
            int years = century * 100;
               int days = (int) (years * 365.2422);
            long  hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");





        }
    }
}
