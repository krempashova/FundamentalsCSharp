using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int>targets=Console.ReadLine()   //52 74 23 44 96 110
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string manipulator = input[0];
                if(manipulator== "Shoot")  //Shoot 5 10
                {
                    int index = int.Parse(input[1]); //5
                    int power = int.Parse(input[2]); //10
                    if(index<0 || index>targets.Count-1)
                    {
                        continue;
                    }
                    else
                    {
                        targets[index] -= power;
                        if(targets[index]<=0)
                        {
                            //targets been shot
                            targets.Remove(targets[index]);
                        }
                    }

                }
                else if(manipulator== "Add")
                {
                    int index = int.Parse(input[1]); //22
                    int value = int.Parse(input[2]); //3
                    if(index<0 || index>targets.Count-1)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    else
                    {
                        targets.Insert(index, value);

                    }
                }
                else if(manipulator== "Strike")
                {
                    int index = int.Parse(input[1]);
                    int radius = int.Parse(input[2]);
                    if(index<0 || index>targets.Count-1)
                    {
                        continue;
                    }
                    else
                    {
                        int indexOfStrikeleft = index - radius;
                        int indexOfStrikeRight = index + radius;
                        if(indexOfStrikeleft<0 
                            || indexOfStrikeRight>targets.Count-1)
                        {
                            Console.WriteLine($"Strike missed!");
                            continue;
                        }
                        else
                        {
                            
                            for (int i = 1; i <= radius; i++)
                            {
                                targets.Remove(targets[index-i]);
                                targets.Remove(targets[index-i]);
                                targets.Remove(targets[index-i]);
                            }

                        }
                            
                    }

                }

            }

                Console.WriteLine(string.Join("|",targets));// end command;
        }
    }
}
