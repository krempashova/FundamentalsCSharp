using System;

namespace _06.TriplesofLatinLetters.DataTypesAndVariables.exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97+n; i++)
            {
                
                for (int j= 97; j < 97+n; j++)
                {
                    
                    for (int y = 97; y <97+ n; y++)
                    {
                        char firstChar = (char)i;
                        char secondChar = (char)j;
                        char thyrdChar = (char)y; ;
                        Console.WriteLine($"{firstChar}{secondChar}{thyrdChar}");
                    }
                }
            }
        }
    }
}
