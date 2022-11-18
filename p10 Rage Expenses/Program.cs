using System;

namespace p10_Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LostGames = int.Parse(Console.ReadLine());
            double HeadsetPrice = double.Parse(Console.ReadLine());
            double MousePrice = double.Parse(Console.ReadLine());
            double keyborsprice = double.Parse(Console.ReadLine());
            double DislpayPrice = double.Parse(Console.ReadLine());

           
            
            double totalforall = ((LostGames / 2) * HeadsetPrice) + ((LostGames / 3) * MousePrice) + 
               + ((LostGames / 6) * keyborsprice) + ((LostGames / 12) * DislpayPrice);
            Console.WriteLine($"Rage expenses: {totalforall:f2} lv.");
        }

    }
}
