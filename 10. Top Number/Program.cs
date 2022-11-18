using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int end = int.Parse(Console.ReadLine());
            
                FindTopNumber(end);
            

        }

        static void FindTopNumber(int end)
        {
            for (int i = 1; i <=end; i++)
            {
                int OddCounter = 0;
                int sum = 0;
                int currentNum = i;
                int numberToDivide = currentNum;
                while (numberToDivide!=0)
                {      //7
                   
                    currentNum = numberToDivide % 10;
                    numberToDivide = numberToDivide / 10;
                   
                   if(currentNum%2!=0)
                    {
                        OddCounter++;
                    }
                    sum = sum + currentNum;
                }
                if(sum%8==0 && OddCounter>=1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
