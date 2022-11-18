
using System.Numerics;

using System;

namespace _08.BeerKegs.DataTypeVariables.ex
{
  
    internal class Program
    {
        static void Main(string[] args)
        {

            int numBeerKeg = int.Parse(Console.ReadLine());
            double VollumeOgKeg = 0;
            double BiggestVolume = double.MinValue;
            string BiggestKegName = string.Empty;
            for (int i = 1; i <= numBeerKeg; i++)
            {
                string beerName = Console.ReadLine();
                double raduis = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());

                VollumeOgKeg = Math.PI * Math.Pow(raduis, 2) *heigth;
                if(VollumeOgKeg>BiggestVolume)
                {
                    BiggestVolume = VollumeOgKeg;
                    BiggestKegName = beerName;  
                }
            }

            Console.WriteLine(BiggestKegName);

        }

        
    }
}
