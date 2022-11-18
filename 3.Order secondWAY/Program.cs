using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3.Order_secondWAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalprice = 1;
            Dictionary<string,List<double>>productscolection
            = new Dictionary<string, List<double>>();

            string cmnd;
            while((cmnd = Console.ReadLine()) != "buy")//Beer 2.50 300
            {
                string[] comand = cmnd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = comand[0];// beer
                double price = double.Parse(comand[1]);//2.50
                double quntity = double.Parse(comand[2]);//300
                if (!productscolection.ContainsKey(product))
                {
                    productscolection[product] = new List<double>();
                    productscolection[product].Add(price);
                    productscolection[product].Add(quntity);

                }
                else

                {
                    foreach (var value in productscolection )
                      
                    {
                        List<double> info =value.Value;
                        double oldquntity = value.Value[1];
                        quntity = oldquntity + quntity;

                        double oldprice = value.Value[0];
                        productscolection[product].Remove(value.Value[0]);
                        productscolection[product].Add(price);
                        quntity = info[0];
                        price = info[1];
                    }
                    
                }
              totalprice = quntity * price;



            }

            foreach (var product in productscolection)
            {

                Console.WriteLine($"{product.Key} -> {(string.Join("",info Where))}");
            }
            


        }
    }
}
