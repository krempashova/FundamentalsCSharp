using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int>firstPlayer=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < firstPlayer.Count; i++)
            {

                for (int j = 0; j < secondPlayer.Count; j++)
                {
                    if (firstPlayer[i] > secondPlayer[j])
                    {
                        firstPlayer.Add(secondPlayer[j]);
                        secondPlayer.Remove(secondPlayer[j]);
                        firstPlayer.Add(firstPlayer[i]);
                        firstPlayer.Remove(firstPlayer[i]);
                    }
                    else if (secondPlayer[j] > firstPlayer[i])
                    {
                        secondPlayer.Add(firstPlayer[i]);
                        firstPlayer.Remove(firstPlayer[i]);
                        secondPlayer.Add(secondPlayer[j]);
                        secondPlayer.Remove(secondPlayer[j]);
                    }
                    else if (firstPlayer[i] == secondPlayer[j])
                        {
                            firstPlayer.Remove(firstPlayer[i]);
                            secondPlayer.Remove(secondPlayer[j]);
                           
                        }
                    if (secondPlayer.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                        return;
                    }
                    if (firstPlayer.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                        return;
                    }

                    i = 0;
                    j = j - 1;
                }
            }

        }
    }
}
