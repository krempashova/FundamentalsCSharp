using System;



namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));


        }

        static int GetSumOfEvenDigits(int num)//12345
        {
            int lastDigit = 0;
            
            int sum = 0;
            while(num>0)
            {
                lastDigit = num % 10;//5
                if(lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                num = num / 10;     
            }
            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int lastDigit = 0;
            int sum = 0;
            while(num>0)
            {
                lastDigit = num % 10;
                if(lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                num = num / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
        }
    }
}
