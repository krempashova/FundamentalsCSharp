using System;
using System.Linq;

namespace _08._Math_Power_new
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
             RaisedToPow(num, pow);
   

        }
         static double RaisedToPow(double num, double pow)
        {
            double result=Math.Pow(num, pow);
            Console.WriteLine(result);
            return result;
        }
    }
}
