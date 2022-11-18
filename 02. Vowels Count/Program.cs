using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine().ToLower();  //SoftUni
            Console.WriteLine(CountOfVowels(text));

        }

       static int  CountOfVowels( string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]=='a'|| text[i] == 'e' || text[i] == 'o' || text[i] == 'u'|| text[i] == 'i'
                    || text[i] == 'y')
                {
                    count++;
                }
                        
            }
            return count;
        }
    }
}
