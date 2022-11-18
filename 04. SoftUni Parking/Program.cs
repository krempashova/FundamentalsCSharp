using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> register =
              new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmnd = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);//register John CS1234JS

                string cmndType = cmnd[0];
                string username = cmnd[1];
                if(cmndType=="register")
                {
                    string licensePlateNumber = cmnd[2];
                    if(!register.ContainsKey(username))
                    {

                        register.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        register[username] = licensePlateNumber;
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                else if(cmndType=="unregister")
                {
                    if(!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }

                }
                
            }
            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}