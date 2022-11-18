using System;
using System.Collections.Generic;

namespace _02._A_Miner_Tasknew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> colection = new Dictionary<string, int>();
            string comand;
            while ((comand = Console.ReadLine())!= "stop")// Gold
            {
                string resourse = comand;
                int quntity = int.Parse(Console.ReadLine());//155
                if(!colection.ContainsKey(resourse))
                {
                    colection[resourse] = 0;
                }
                colection[resourse] += quntity;
            }
            foreach (var item in colection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
