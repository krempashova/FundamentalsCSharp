using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (operation=='/')
            {
                Console.WriteLine(DividebyNums(firstNum, secondNum));
            }
            else if(operation=='*')
            {
                Console.WriteLine(MultiplyByNums(firstNum,secondNum));
            }
            else if(operation=='+')
            {
                Console.WriteLine(AddingbyNums(firstNum, secondNum));
            }
            else if(operation=='-')
            {
                Console.WriteLine(SubtractionbyNums(firstNum,secondNum));
            }
                    
        }

         static int SubtractionbyNums(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }

        static int AddingbyNums(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        static int  MultiplyByNums(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }

        static double  DividebyNums(int firstNum, int secondNum)
        {
            double result = (firstNum) / secondNum;
            return result;
        }

    }
}
