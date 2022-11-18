using System;

namespace _11._Refactor_Volume_of_Pyramidnew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
              double length = double.Parse(Console.ReadLine());
                 //Console.Write("Length: ");
            
             double width= double.Parse(Console.ReadLine());
            //Console.Write("Width: ");

            //Console.WriteLine("Heigth: ");
            double  heigth= double.Parse(Console.ReadLine());
           
            double v = (length * width*heigth ) / 3;
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");

            Console.WriteLine($"Pyramid Volume: {v:f2}");

          
        }
    }
}
