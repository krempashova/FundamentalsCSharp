using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vechicle> vechiclescolection = new List<Vechicle>();
            List<double>carpower=new List<double>();
            List<double> truckpower = new List<double>();
            string cmnArg;
            while ((cmnArg = Console.ReadLine()) != "End")//"{typeOfVehicle} {model} {color} {horsepower}"
            {
                string[] info = cmnArg.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string typeOfVehicle = info[0]; // car
                string model = info[1];// ferrari
                string color = info[2];// red
                double horsepower = double.Parse(info[3]);//520
                if(typeOfVehicle=="car")
                {
                   carpower.Add(horsepower);
                }
                else if(typeOfVehicle=="truck")
                {
                    truckpower.Add(horsepower);
                }

                Vechicle vechicle = new Vechicle(typeOfVehicle, model, color, horsepower);
                vechiclescolection.Add(vechicle);

            }

            string comand;
            while ((comand = Console.ReadLine()) != "Close the Catalogue")
            {
                

                string currentModel = comand;
                foreach (var vehicle in vechiclescolection.Where(x => x.Model == currentModel))
                {
                    if (vehicle.Type == "car")
                    {
                        Console.WriteLine("Type: Car");
                    }
                    else
                    {
                        Console.WriteLine("Type: Truck");
                    }

                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                }

            }
            if (vechiclescolection.Where(x => x.Type == "car").Count() == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");

            }
            else
            {
                double averagecarpower = carpower.Average();
                Console.WriteLine($"Cars have average horsepower of: {averagecarpower:f2}.");
            }
            if (vechiclescolection.Where(x => x.Type == "truck").Count() == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");

            }
            else
            {
                double averagetruckpower = truckpower.Average();
                Console.WriteLine($"Trucks have average horsepower of: {averagetruckpower:f2}.");
            }
           
        }
        public class Vechicle
        {
            public Vechicle(string typeOfVehicle, string model, string color, double horsepower)
            {
                Type = typeOfVehicle;
                Model = model;
                Color = color;
                Horsepower = horsepower;

            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
        }

    }
}
