using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" ");//add 5
                if (input[0] == "Add")
                {
                    int value = int.Parse(input[1]);
                    numbers.Add(value);
                }
                else if (input[0] == "Insert")
                {
                    int value = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, value);
                }
                else if (input[0] == "Remove")
                {
                    int index = int.Parse(input[1]);
                   
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;

                    }
                    numbers.RemoveAt(index);

                }
                else if (input[0] == "Shift")
                {
                    if (input[1] == "left")
                    {

                        int count = int.Parse(input[2]);// 23 29 18 43 21 20 1
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.Remove(firstNum);
                            numbers.Add(firstNum);

                        }

                    }
                    else if (input[1] == "right")
                    {
                        int count = int.Parse(input[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Remove(lastNum);
                            numbers.Insert(0, lastNum);
                        }



                    }
                }

            }
            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
