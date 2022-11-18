using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucksCatalog = new List<Truck>();
            List<Car> carsCatalog = new List<Car>();
            string cmnArg;
            while((cmnArg=Console.ReadLine())!="end")
            {
                string []info=cmnArg.Split("/",StringSplitOptions.RemoveEmptyEntries); //Car/Audi/A3/110
                string type = info[0];
                string brand = info[1];

                if(type=="Car")
                {
                    string model = info[2];
                    int horsepower = int.Parse(info[3]);
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsepower,


                    };

                    
                    carsCatalog.Add(car);
                 
                }
                else if(type=="Truck")
                {
                    string model = info[2];
                    int weight=int.Parse(info[3]);
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight,

                    };
                    trucksCatalog.Add(truck);
                }
            }

            if(carsCatalog.Count>0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in carsCatalog.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                }
            }
           if(trucksCatalog.Count>0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucksCatalog.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    //public class Catalog
    //{
    //    public List<Car> carsCatalog { get; set; }    
    //    public List<Truck> trucksCatalog { get; set; }


    //}
    public class Truck
    { //Brand, Model, and Weight.
        public string  Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    public class Car
    {
        //Brand, Model, and Horse Power.
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

}
