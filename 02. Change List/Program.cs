using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            string input;
            while((input=Console.ReadLine())!="end")
            {
                string[] command =input.Split(" ");
                if(command[0] == "Delete")

                {
                    int element=int.Parse(command[1]);
                    numbers.RemoveAll(x=>(x==element));

                }
                else if(command[0]== "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index,element);  
                }
            }

            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
