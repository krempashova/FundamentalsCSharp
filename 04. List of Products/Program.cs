using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());//4
            List<string> Products = new List<string>();
            for (int i = 0; i < n; i++)
            {
               
                string CurrentProduct = Console.ReadLine();
                Products.Add(CurrentProduct);
                     
            }

            Products.Sort();
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{Products[i]}");
            }

        }
    }
}
