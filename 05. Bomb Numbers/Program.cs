using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> sequence = Console.ReadLine()       // 1 2 2 4 2 2 2 9
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            List<int> Arg = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)  // 4 2
               .Select(int.Parse)
               .ToList();
            int BombNumber = Arg[0];
            int powerOfdetonaation = Arg[1];

           
            Printdetonation(sequence, BombNumber,powerOfdetonaation);
            Console.WriteLine(sequence.Sum());

        }

        static void Printdetonation(List<int>sequence, int BombNumber,int powerOfdetonaation)
        {
            for(int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == BombNumber)
                {
                    for (int j = 0; j < powerOfdetonaation; j++)
                    {
                        int leftIndex = i - 1;

                        if (leftIndex == 0)
                        {
                            sequence.RemoveAt(leftIndex);
                            i = i - 1;
                            break;
                        }
                        else if (leftIndex < 0)
                        {
                            break;
                        }
                        else if (leftIndex > 0)
                        {
                            sequence.RemoveAt(leftIndex);
                            i = i - 1;
                        }
                    }

                    for (int j = 0; j < powerOfdetonaation; j++)
                    {
                        int rightIndex = i + 1;

                        if (rightIndex == sequence.Count - 1)
                        {
                            sequence.RemoveAt(rightIndex);
                            break;
                        }
                        else if (rightIndex > sequence.Count - 1)
                        {
                            break;
                        }
                        else if (rightIndex < sequence.Count - 1)
                        {
                            sequence.RemoveAt(rightIndex);
                        }
                    }

                    sequence.Remove(BombNumber);
                    i = -1;
                }
            }
        }
    }
}