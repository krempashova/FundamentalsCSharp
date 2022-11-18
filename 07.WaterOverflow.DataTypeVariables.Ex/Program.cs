using System;

namespace _07.WaterOverflow.DataTypeVariables.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numLines = int.Parse(Console.ReadLine());
            int capacitywaterTank = 255;
            int pouredLitters = 0;
            for (int i = 1; i <= numLines; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                pouredLitters += litters;
                if(pouredLitters> capacitywaterTank)
                {
                    Console.WriteLine("Insufficient capacity!" );
                    pouredLitters -= litters;
                }
               
            }
            Console.WriteLine(pouredLitters);
        }
    }
}
