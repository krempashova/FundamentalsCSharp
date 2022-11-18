using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            int countChangesmade = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ");

                if (command[0] == "Add")
                {
                    int value = int.Parse(command[1]);
                    numbers.Add(value);
                    countChangesmade++;
                }
                else if (command[0] == "Remove")
                {
                    int value = int.Parse(command[1]);
                    numbers.Remove(value);
                    countChangesmade++;
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                    countChangesmade++;

                }
                else if (command[0] =="Insert")
                {
                    int value = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, value);
                    countChangesmade++;
                }
                else if(command[0]=="Contains")
                {
                    int value = int.Parse(command[1]);
                    
                    if(numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(command[0]=="PrintEven")
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(X=>X%2==0)));
                }
                else if(command[0]=="PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(X => X % 2 != 0)));
                }
                else if(command[0]=="GetSum")
                {
                    
                    Console.WriteLine(numbers.Sum());
                }
                else if(command[0]== "Filter")
                {
                    string condition = command[1];
                    int value = int.Parse(command[2]);  
                    if(condition==">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >value)));
                    }
                    else if(condition=="<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if(condition==">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }
                    else if(condition=="<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));
                    }

                }
            }



            if (countChangesmade > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
           

        }
    }
}
