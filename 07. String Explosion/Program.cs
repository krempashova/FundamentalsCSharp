using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//abv>1>1>2>2asdasd

            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if(currChar=='>')
                {
                    char bomb = currChar;
                    char power =text[i + 1];
                    if(power > 0 && power!='>')
                    {
                        text = text.Remove(text[i + 1],1);
                    }
                   
                }
            }

        }
    }
}
