using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = 0;
            List<string> elements = Console.ReadLine() //1 1 2 2 3 3 4 4 5 5 
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command; 
            while((command=Console.ReadLine())!="end")
            {
                moves++;
                string[] input = command.Split(" ");
                int index1 = int.Parse(input[0]);
                int index2=int.Parse(input[1]);
                if (index1 == index2 || index1>elements.Count-1|| index1 < 0 
                    ||  index2 >elements.Count-1||index2 < 0)
                {
                    TryingTocheat(elements, index1, index2,moves);                 
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;

                }
                string firstElement = elements[index1];
                string secondElement = elements[index2];   
                
                if(firstElement==secondElement && elements.Count!=0)
                {
                    if (index1 > index2)
                    {
                        elements.Remove(firstElement);
                        elements.Remove(secondElement);
                        Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");
                    }
                    else
                    {
                        elements.Remove(secondElement);
                        elements.Remove(firstElement);
                        Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");
                    }
                    
                    
                }
                else if(firstElement!=secondElement)
                {
                    Console.WriteLine("Try again!");
                    continue;
                   
                }
                if(elements.Count==0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }         

            }
            if(elements.Count!=0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }   

        }

         static void TryingTocheat(List<string> elements, int index1, int index2, int moves)
        {
                string insert = $"-{moves}a";
                elements.Insert(elements.Count / 2,insert);
                elements.Insert(elements.Count / 2, insert);
                
            
                    


        }
    }
}
