using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            int[] numbers = Console.ReadLine()  ///1 3 5 7 9
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] manupulatedArray = new int[numbers.Length];
            string comand;
            while((comand=Console.ReadLine())!="end")  //exchange 1
            {
                string[] input = comand.Split(" ");
                string manupulator =input[0]; //exchange
                 if(manupulator=="exchange")
                {
                    int indextosplit = int.Parse(input[1]);//1 //579 13
                    if(indextosplit<0 || indextosplit>numbers.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    ExchangeArrayByIndex(numbers, indextosplit,manupulatedArray);

                }
                else if(manupulator=="max")
                {

                }
                 else if(manupulator=="min")
                {

                }
                 else if(manupulator=="first")
                {

                }
                 else if(manupulator== "last")
                {

                }





            }

        }

      static void ExchangeArrayByIndex(int[] numbers, int indextosplit, int [] manipulatedArray)
        {
            for (int i = indextosplit+1; i <numbers.Length; i++)
            {

                for (int j = 0 ; j<numbers.Length-1-indextosplit; j++)
                {
                    manipulatedArray[j] = numbers[i];
                    i++;
                }
                i = indextosplit + 1;
            }
           

        }
    }
}
