using System;
using System.Linq;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstvalue = Console.ReadLine();
            string secondvalue = Console.ReadLine();
            if(input=="int")
            {
               int  firstint=int.Parse(firstvalue);
                int secondint = int.Parse(secondvalue);
                int result = GetMax(firstint, secondint);
                Console.WriteLine( result);
            }
            else if(input=="char")
            {
                char firstChar = char.Parse(firstvalue);
                char secondChar = char.Parse(secondvalue);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if(input=="string")
            {
                string result = GetMax( firstvalue, secondvalue);
                Console.WriteLine(result);
            }
                    


            
        }
        static int  GetMax(int a, int b)

        {
            if(a>b)
            {
                return a;

            }
            else
            {
                return b;
            }
        }
        static char GetMax(char a, char b)
        {
            if(a>b)
            {
                return a;

            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            
            int result=a.CompareTo(b);
            if(result>0)
            {
                return a;
            }
            return b;
        }
            
    }
}
