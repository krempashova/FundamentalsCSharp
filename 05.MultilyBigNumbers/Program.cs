using System;
using System.Text;

namespace _05.MultilyBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine(); //9999
            int mulitplier = int.Parse(Console.ReadLine()); // 9
            var sb = new StringBuilder();
            int reminder = 0;

            if (mulitplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--) //9999
            {
                int currDigit = int.Parse(input[i].ToString()); // 9
                int product = currDigit * mulitplier + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
      
    

