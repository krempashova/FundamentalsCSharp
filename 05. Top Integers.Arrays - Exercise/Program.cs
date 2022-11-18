using System;
using System.Linq;

namespace _05._Top_Integers.Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] integers = Console.ReadLine()//1 4 3 2
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            
            for (int i = 0; i < integers.Length; i++)
            {
                int CurrentNum=integers[i];
                bool isTopInteger = true;
                for (int j = i+1; j < integers.Length; j++)
                {
                    int nextNum = integers[j];
                    if(nextNum>=CurrentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                   
                }
                if (isTopInteger)
                {
                    Console.Write(CurrentNum + " ");
                }
            }
                    





        }
    }
}
