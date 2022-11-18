using System;

namespace P11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double totalforeachOrder = 0;
            double totalforallorders = 0;
            for (int i = 1; i <= N; i++)
            {
                double priceForCapsule = double.Parse(Console.ReadLine());
                int DAYS = int.Parse(Console.ReadLine());
                int csCount = int.Parse(Console.ReadLine());
                totalforeachOrder = (csCount * DAYS) * priceForCapsule;
                Console.WriteLine($"The price for the coffee is: ${totalforeachOrder:f2}");
                totalforallorders += totalforeachOrder;
            }

            Console.WriteLine($"Total: ${totalforallorders:f2}");
        }
    }
}
