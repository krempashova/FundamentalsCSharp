using System;
using System.Linq;

namespace _09._Kamino_Factory.ArrayExersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestLengthforall = 1;
            int bestStartIndex = 0;
            int bestSequencesUM = 0;
            int sequenceCounter = 0;
            int bestSequanceIndex = 0;
            int[] bestSequence = new int[n];

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {

                int[] currentSequence = input
                    .Split("!",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sequenceCounter++;
                int length = 1;
                int startIndex = 0;
                int bestcurrentLenght = 1;
                int sumCurrenrSequence = 0;
                input = Console.ReadLine();
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > bestcurrentLenght)
                    {
                        bestcurrentLenght = length;
                        startIndex = i;
                    }
                    sumCurrenrSequence += currentSequence[i];
                    
                }
                sumCurrenrSequence += currentSequence[n - 1];
                if (bestcurrentLenght > bestLengthforall)
                {
                    bestLengthforall = bestcurrentLenght;
                    bestStartIndex = startIndex;
                    bestSequencesUM = sumCurrenrSequence;
                    bestSequanceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestLengthforall == bestcurrentLenght)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLengthforall = bestcurrentLenght;
                        bestStartIndex = startIndex;
                        bestSequencesUM = sumCurrenrSequence;
                        bestSequanceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (sumCurrenrSequence > bestSequencesUM)
                        {
                            bestLengthforall = bestcurrentLenght;
                            bestStartIndex = startIndex;
                            bestSequencesUM = sumCurrenrSequence;
                            bestSequanceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }

                }


            }

            Console.WriteLine($"Best DNA sample {bestSequanceIndex} with sum: {bestSequencesUM}.");
            Console.WriteLine(string.Join(" ", bestSequence));




        }
    }
}
