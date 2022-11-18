using System;
using System.Linq;


namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintResult(productName, quantity);

        }

        static void  PrintResult(string productName, int quantity)
        {
            double result = 0.00;
            switch (productName)
            {
                
                case "coffee":
                    result = 1.50 * quantity;

                    break;
                case "water":
                    result = 1.00 * quantity;
                    break;
                case "coke":
                    result = 1.40 * quantity;
                    break;
                case "snacks":
                    result = 2.00 * quantity;
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }


            }


}
