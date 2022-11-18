using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string badwords = Console.ReadLine();//ice
            string text = Console.ReadLine();//icebgdicemhfg

            while(text.Contains(badwords))
            {
                int index = text.IndexOf(badwords);
                text = text.Remove(index, badwords.Length);




            }


            Console.WriteLine(text);



        }
    }
}
