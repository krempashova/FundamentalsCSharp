using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int []numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] input = command.Split(" ",StringSplitOptions.RemoveEmptyEntries); //swap 1 3

                string action = input[0];
                if(action=="swap")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);
                    SwapedNumbers(numbers, index1, index2);
                }
                else if(action== "multiply")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);
                    MultiplyNumbers(numbers,index1, index2);
                    
                }
                else if(action== "decrease")
                {
                    DecreaseNumbers(numbers);
                }
            }

            Console.WriteLine(String.Join(", ",numbers));
        }

        static void DecreaseNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= 1;
            } 

        }

        static void MultiplyNumbers(int[] numbers,int index1, int index2)
        { 
            int firstMulptiplyer = numbers[index1];
            int secondMultiplyer = numbers[index2];
            int rezult = firstMulptiplyer * secondMultiplyer;
            numbers[index1] = rezult;
        }

        static void SwapedNumbers(int[] numbers, int index1, int index2)
        {
          int swap=numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = swap;
        }
    }
}
