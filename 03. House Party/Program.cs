using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> GuestList=new List<string>();  
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine()    //name is going
                     .Split()
                     .ToList();
                string name = command[0];
                if (command[2]=="going!")
                {
                    if (!GuestList.Contains(name))
                    {
                        GuestList.Add(name); ;
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    
                    
                    
                }
                else if(command[2]=="not")     // name is not Going
                {
                    if(GuestList.Contains(name))
                    {
                        GuestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        
                    }
                }
            }

            Console.WriteLine(string.Join("\r\n",GuestList));
        }
    }
}
