using System;
using System.Linq;


namespace _01._Sign_of_Integer_Numbers.Methods.lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrinNumber(int.Parse(Console.ReadLine()));



        }
        static void PrinNumber(int number)
        {
            if(number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if(number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if(number==0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }


    }
}
