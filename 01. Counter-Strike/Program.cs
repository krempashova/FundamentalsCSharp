using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int winCount = 0;
            string command;
            while((command=Console.ReadLine())!="End of battle"&& energy>=0)
            {
                int distance = int.Parse(command);
                if(distance<=energy)
                {  //you win  a battle;
                    energy -= distance;
                    winCount++;
                }
                else if(distance>=energy)
                {// you lose the battle;and the game ends;
                    Console.WriteLine($"Not enough energy! Game ends with {winCount} won battles and {energy} energy");
                    return;
                }
                if(winCount%3==0)
                {
                    energy += winCount;
                }
                
            }
            Console.WriteLine($"Won battles: {winCount}. Energy left: {energy}");
        }
    }
}
