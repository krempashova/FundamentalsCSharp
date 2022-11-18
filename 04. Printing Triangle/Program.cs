using System;
using System.Linq;


namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)//rows
            {
                Printtriangle(i);
            }
            for (int i = n-1 ; i >= 1; i--)
            {
                Printtriangle(i);
            }


        }
        static void Printtriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
