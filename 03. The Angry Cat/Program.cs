using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalsumofleftdamage = 0;
            int totaLSumOfRightdamage = 0;
            List<int> priceRaiting = Console.ReadLine() //1, 5, 1
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            int entryPointindex = int.Parse(Console.ReadLine()); //1
            string type = Console.ReadLine(); // cheap

            if (type == "cheap")
            {
                for (int i = entryPointindex + 1; i < priceRaiting.Count; i++)
                {
                    if (priceRaiting[i] < priceRaiting[entryPointindex])
                    {
                        totaLSumOfRightdamage += priceRaiting[i];
                    }
                }

                for (int i = entryPointindex - 1; i >= 0; i--)
                {
                    if (priceRaiting[i] < priceRaiting[entryPointindex])
                    {
                        totalsumofleftdamage += priceRaiting[i];
                    }
                }

            }
            else if (type == "expensive")
            {
                for (int i = entryPointindex + 1; i < priceRaiting.Count; i++)
                {
                    if (priceRaiting[i] >= priceRaiting[entryPointindex])
                    {
                        totaLSumOfRightdamage += priceRaiting[i];
                    }
                }

                for (int i = entryPointindex - 1; i >= 0; i--)
                {
                    if (priceRaiting[i] >= priceRaiting[entryPointindex])
                    {
                        totalsumofleftdamage += priceRaiting[i];
                    }
                }
            }

            if (totalsumofleftdamage >= totaLSumOfRightdamage)
            {
                Console.WriteLine($"Left - {totalsumofleftdamage}");
            }

            else 
            {
                Console.WriteLine($"Right - {totaLSumOfRightdamage}");
            }
        }

    }

}          

    

