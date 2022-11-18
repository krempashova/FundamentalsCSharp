using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood=Console.ReadLine() // 10 10 10 2
                .Split("@",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            int position = 0;
            while((input=Console.ReadLine())!="Love!") //jump 1
            {
                string[]jump=input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string commnad = jump[0];
                int lenghtOfJump =int.Parse(jump[1]);
                position+=lenghtOfJump;
                if(position>neighborhood.Count-1)
                {
                    position = 0;
                }
                if(neighborhood[position]==0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }
               else
                {
                    neighborhood[position] -= 2;
                    if (neighborhood[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }
               
            }
                      Console.WriteLine($"Cupid's last position was {position}.");
                 int count = neighborhood.Count(x => x > 0);
                   int sum = neighborhood.Sum();
            if (sum==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
