using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            
            
                Console.WriteLine(smallestOfintegers(firstNum,secondNum,lastNum));
            

        }

        static int smallestOfintegers(int firstNum, int secondNum, int lastNum)
        {
            int smallestnum = 0;
           if(firstNum<secondNum && firstNum<lastNum)
            {
                smallestnum = firstNum;
            }
           else if(secondNum<firstNum && secondNum<lastNum)
            {
                smallestnum = secondNum;
            }
           else if(lastNum<firstNum && lastNum<secondNum)
            {
                smallestnum = lastNum;
            }
           else
            {
                smallestnum = firstNum;
            }
            return smallestnum;
        }
    }
}
