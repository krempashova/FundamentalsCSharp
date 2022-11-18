using System;

namespace _05.PrintPartOfASCIITable.Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <=end ; i++)
            {
                char currCh = (char)i;
                Console.Write(currCh+" ");

            }

         
        }
    }
}
