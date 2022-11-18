using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[] gudungeonsrooms = Console.ReadLine() // cat 10|potion 50|orc 10|chest 10|potion 80|
                                                          // snake 25
                                                          // 
                 .Split("|")
                 .ToArray();

            int initailHelth = 100;
            int totalbitcoins = 0;

            for (int i = 0; i < gudungeonsrooms.Length; i++)
            {
                string[] command = gudungeonsrooms[i].Split(" "); //rat 10
                string name = command[0];

                if(name== "potion")
                {
                    int potionhelth =int.Parse(command[1]);
                    if(initailHelth<100)
                    {
                        initailHelth += potionhelth;
                        if(initailHelth>100)
                        {
                            potionhelth = 100-(initailHelth - potionhelth);
                            initailHelth = 100;
                        }
                    }
                    else if(initailHelth>=100)
                    {
                        initailHelth = 100;
                    }
                    Console.WriteLine($"You healed for {potionhelth} hp.");
                    Console.WriteLine($"Current health: {initailHelth} hp.");
                }
                else if(name=="chest")
                {
                     int bitcoins = int.Parse(command[1]);
                    //you found Bitcoins;
                    Console.WriteLine($"You found {bitcoins} bitcoins.");
                    totalbitcoins += bitcoins;

                }
                else
                {
                    string monstername = name;

                    int attack =int.Parse(command[1]);
                    initailHelth -= attack;
                    if(initailHelth>0)
                    { // i win
                        Console.WriteLine($"You slayed {monstername}.");
                    }
                    else

                    {
                        Console.WriteLine($"You died! Killed by {monstername}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {totalbitcoins}");
            Console.WriteLine($"Health: {initailHelth}");
        }
    }
}
