using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while(( input=Console.ReadLine())!="end")
            {
                string[] command = input.Split(" ");

                if(command[0]=="Add")
                {
                    int value=int.Parse(command[1]);  
                    numbers.Add(value); 
                }
                else if(command[0]== "Remove")
                {
                    int value = int.Parse(command[1]);
                    numbers.Remove(value);
                }
                else if(command[0]== "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);

                }
                else if(command[0]== "Insert")
                {
                    int value = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, value);
                }
                        

            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
