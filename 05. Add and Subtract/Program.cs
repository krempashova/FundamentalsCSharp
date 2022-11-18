using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int sumOfFisrtTwoInt=SumOfFirstandSecond(firstNum,secondNum);
            Console.WriteLine(SubstarctlastFromSum(sumOfFisrtTwoInt,lastNum));

        }

        static int  SubstarctlastFromSum(  int sumOfFirstTwoInt, int lastNum)
        {
            int substract = sumOfFirstTwoInt - lastNum;
            return substract;
        }

        static int SumOfFirstandSecond(int firstNum, int secondNum)
        {
            int sum= firstNum + secondNum;
            return sum;
        }
    }
}
