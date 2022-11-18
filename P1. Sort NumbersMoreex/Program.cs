using System;

namespace P1._Sort_NumbersMoreex
{
    internal class Program
    {
        static void Main(string[] args)
        { 
  


                int num1= int.MinValue;
                int num2 = int.MinValue;
                int num3 = int.MinValue;

                for (int i = 0; i < 3; i++)
                {
                    int numberToCheck = int.Parse(Console.ReadLine());
                    if (numberToCheck > num1)
                    {
                        num3 = num2;
                        num2 = num1;
                        num1 = numberToCheck;
                    }
                    else if (numberToCheck > num2)
                    {
                        num3 = num2;
                        num2 = numberToCheck;
                    }
                    else if (numberToCheck >  num3)
                    {
                         num3 = numberToCheck;
                    }

                }
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
        }
    }

