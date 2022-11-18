using System;

namespace P07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sumcoins = 0;
            string command;
            while((command=Console.ReadLine())!="Start")//1
            {
                 double coins = double.Parse(command);  
                switch(coins)
                {
                    case 0.10:
                       
                    case 0.20:
                       
                    case 0.50:
                       
                    case 1.00:
                      
                    case 2.00:
                        sumcoins += coins;
                            
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                       
                }
                



            }
            double priceProduct = 0;
            while((command=Console.ReadLine())!="End")
            {
                string product = command;
                switch(product)
                {

                    case "Nuts":
                        priceProduct = 2.00;
                        sumcoins -= priceProduct;
                        if (sumcoins < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumcoins += priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        priceProduct = 0.70;
                        sumcoins -= priceProduct;
                        if (sumcoins < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumcoins += priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Purchased water");
                        }
                        break;

                    case "Crisps":
                       priceProduct=1.50;
                        sumcoins -= priceProduct;
                        if (sumcoins < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumcoins += priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Purchased crisps");
                        }
                        break;

                    case "Soda":
                        priceProduct = 0.80;
                        sumcoins -= priceProduct;
                        if (sumcoins < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumcoins += priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Purchased soda");
                        }
                        break;

                    case "Coke":
                        priceProduct = 1.00;
                        sumcoins -= priceProduct;
                       
                        if(sumcoins<0)//-8
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumcoins = sumcoins + priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            double change = sumcoins; 
            Console.WriteLine($"Change: {change:f2}");
            
        }
    }
}
