using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();//Agd#53Dfg^&4F53
            string chars = string.Empty;
            string symbols = string.Empty;
            string nums = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
               if (char.IsDigit(text[i]))
                {
                    nums += text[i].ToString();

                }
               else if (char.IsLetter(text[i]))
                {
                    chars+= text[i].ToString();
                }

               else
                {
                    symbols += text[i].ToString();
                }

            }

            Console.WriteLine(nums);
            Console.WriteLine(chars);
            Console.WriteLine(symbols);


        }
    }
}
