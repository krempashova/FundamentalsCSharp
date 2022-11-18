using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totaltaxes = 0;
            double totalsum = 0;
            double totaloUTtax = 0;
            string command;
            while((command = Console.ReadLine()) !="special"&& command!="regular")
            {
                double partPrice = double.Parse(command);
                if(partPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totaloUTtax += partPrice;
                totaltaxes += (partPrice * 0.20);
                totalsum = totaloUTtax + totaltaxes;

            }
            if(command=="special")
            {
                if (totalsum == 0)
                {
                    Console.WriteLine("Invalid order!");
                    return;
                }
                    totalsum = totaloUTtax + totaltaxes;
                    totalsum = totalsum - (totalsum * 0.10);
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totaloUTtax:f2}$");
                    Console.WriteLine($"Taxes: {totaltaxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalsum:f2}$");
                
            }
            else if(command=="regular")
            {
                if (totalsum == 0)
                {
                    Console.WriteLine("Invalid order!");
                    return;
                }
                totalsum = totaloUTtax + totaltaxes;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totaloUTtax:f2}$");
                Console.WriteLine($"Taxes: {totaltaxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalsum:f2}$");
            }



        }
    }
}
