using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("\\");//C:\Internal\training-internal\
            string[] filename = input[input.Length-1].Split(".",StringSplitOptions.RemoveEmptyEntries);   
            //Template.pptx
            string file=filename[0];
            string extension = filename[1];
            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");







        }
    }
}
