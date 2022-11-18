using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            string MiddleChar=MiddleCharacters(input);
            Console.WriteLine(MiddleChar);  
        }

         static string MiddleCharacters(string text)//7chars
        {
            if(text.Length%2==1)
            {
                return text[text.Length/2].ToString();
                
            }
            else
            {
                return ("" + text[(text.Length / 2) - 1] + text[(text.Length / 2)]).ToString();
            }
        }
    }
}
