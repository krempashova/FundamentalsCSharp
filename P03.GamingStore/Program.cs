using System;

namespace P03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input;
            double spendMoney = 0;
            while((input=Console.ReadLine())!= "Game Time")
            {
                string GameName = input;
                switch(GameName)
                {
                    case "OutFall 4":
                        spendMoney += 39.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 39.99;
                        }
                        else 
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        break;
                        if(spendMoney-budget==0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                    case "CS: OG":
                        spendMoney += 15.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 15.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        if (spendMoney - budget == 0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                        break;
                        
                    case "Zplinter Zell":
                        spendMoney += 19.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 19.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        if (spendMoney - budget == 0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                        break;

                    case "Honored 2":
                        spendMoney += 59.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 59.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        if (spendMoney - budget == 0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch":
                        spendMoney += 29.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 29.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        if (spendMoney - budget == 0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        spendMoney += 39.99;
                        if (spendMoney > budget)
                        {
                            Console.WriteLine("Too Expensive");
                            spendMoney -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {GameName}");
                        }
                        if (spendMoney - budget == 0)
                        {
                            Console.WriteLine($"Out of money!");
                            return;
                        }
                        break;

                        break;
                       
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        
                }
              

            }
            Console.Write($"Total spent: ${spendMoney:f2}. ");
            double remainding = budget - spendMoney;
            Console.Write($"Remaining: ${remainding:f2}");
        
        }
    }
}
