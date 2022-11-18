using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productprice = new Dictionary<string,double>();
            Dictionary<string, int> productquantity = new Dictionary<string, int>();

            string[] input = Console.ReadLine()//Beer| 2.20 |100
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string comand=input[0];
            
            while(comand!="buy")//
            {
                string productname = comand;//Beer
                double price = double.Parse(input[1]);//2.20
                int quntity = int.Parse(input[2]);//200

                if (!productquantity.ContainsKey(productname))
                {
                    productquantity.Add(productname, quntity);
                    productprice.Add(productname, price);
                }
                else
                {
                    productprice[productname] = price;
                    productquantity[productname] += quntity;
                   
                }
               

                 input = Console.ReadLine()//Beer| 2.20 |100
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                 comand = input[0];
            }
           

            foreach (var product in productprice)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value * productquantity[product.Key]):F2}");
            }
           

        }
    }
}
