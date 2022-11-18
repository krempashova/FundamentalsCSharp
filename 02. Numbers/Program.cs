using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)   //1 4 5 19
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) !="Finish")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries); //Add 1
                string manipulator = command[0];  //add
                if (manipulator =="Add")
                {
                    int value = int.Parse(command[1]);
                    numbers.Add(value);
                }
                else if (manipulator =="Remove")  //Remove 4
                {
                    int value = int.Parse(command[1]);
                    numbers.Remove(value);

                }
                else if (manipulator =="Replace")//Replace 9 10
                {
                    int value = int.Parse(command[1]);
                    int replacement = int.Parse(command[2]);
                    if (numbers.Contains(value))
                    {
                        int index = numbers.IndexOf(value);
                        numbers.RemoveAt(index);
                        numbers.Insert(index, replacement);
                    }
                }
                else if (manipulator =="Collapse")
                {
                    int value = int.Parse(command[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < value)
                        {
                            numbers.Remove(numbers[i]);
                            i = -1;
                        }
                    }
                }

                }
            Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }

