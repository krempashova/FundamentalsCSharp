using System;
using System.Linq;

namespace _08._Math_Power
{
    internal class Program 
    {
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
                 RaisedToPow(number, power);  

        }

       static double  RaisedToPow(double number, double power)
        {
            double result=Math.Pow(number, power);
            Console.WriteLine(result);
            return result;
        }

         }
            
    }

