using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Programm
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split("/").ToArray();
                
                string typeV = info[0];
                string brand = info[1];
                string model = info[2];
                int HPorW = int.Parse(info[3]);
                
                if (typeV == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = HPorW;
                    catalogue.Cars.Add(car);
                } else if (typeV == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = HPorW;
                    catalogue.Trucks.Add(truck);
                }
            }
            if (catalogue.Cars.Count > 0)
            {
                List<Car> sortedCars = catalogue.Cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> sortedTrucks = catalogue.Trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
           
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Catalogue
        {
            public List<Car> Cars = new List<Car>();
            public List<Truck> Trucks = new List<Truck>();
        }
    }
}

