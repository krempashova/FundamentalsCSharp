using System;
using System.Linq;


namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int timesToRepeat = int.Parse(Console.ReadLine());
            string result= repeatString(text,  timesToRepeat);
            Console.WriteLine(result);

        }
        static string repeatString (string text, int timesToRepeat)
            {
            string RepeatText = text;
            for (int i = 1; i <timesToRepeat; i++)
            {
                RepeatText += text;
                    
            }
            return RepeatText;
            }
         
			
        }
    }


