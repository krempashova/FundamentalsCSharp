using System;
using System.Linq;

namespace _08._Magic_Sum.Array_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int equalSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                
                    int firstNum=arr[i];       //1 7 6 2 19 23
                for (int j = i+1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];
                    if(firstNum+secondNum==equalSum)
                    {
                        Console.Write($"{firstNum} {secondNum}");
                        Console.WriteLine();
                            break;
                    }
                }
            }




        }
    }
}
