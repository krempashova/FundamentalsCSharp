using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons=Console.ReadLine()//32 54 21 12 4 0 23
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());//75

            string input;
            while((input=Console.ReadLine())!="end")
            {
                string[] command = input.Split(" ");

                if(command[0]=="Add")         //Add 10
                {
                    int newWagon = int.Parse(command[1]);
                    wagons.Add(newWagon);

                }

                else
                {
                    int passengertoFit = int.Parse(command[0]);
                    for (int i = 0; i<wagons.Count; i++)
                    {
                       if(wagons[i]+passengertoFit<=capacity)
                        {
                            wagons[i] += passengertoFit;
                            break;
                        }

                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
