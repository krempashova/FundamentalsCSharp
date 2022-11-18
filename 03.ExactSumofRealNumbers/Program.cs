using System;

namespace _03.ExactSumofRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
           int n =int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 1; i <=n; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                 sum+= currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
