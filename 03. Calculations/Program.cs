using System;
using System.Linq;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch(operation)
            {
                case "add":
                    addNumbers(a, b);
                    break;
                case "multiply":
                    multiplyNumbers(a, b);
                    break;
                case "subtract":
                    subtractNumbers(a, b);
                    break;
                case "divide":
                    divideNumbers(a, b);
                    break; 
            }



       }

        static void addNumbers(int a, int b)
        {
            Console.WriteLine(a+b);
            
        }
        static void multiplyNumbers(int  a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void subtractNumbers(int  a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void divideNumbers(int a, int b)
        {
            Console.WriteLine(a/b);
        }
            

    }
}
