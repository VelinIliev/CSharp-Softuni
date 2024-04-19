using System;
using System.Linq;
using System.Globalization;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] info = input.Split(" ").ToArray();
                string typeVehicle = info[0];
                string model = info[1];
                string color = info[2];
                double horsePower = double.Parse(info[3]);

                Car car = new Car(typeVehicle, model, color, horsePower);
                catalogue.Cars.Add(car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                string carModel = input;

                foreach (Car car in catalogue.Cars)
                {
                    if (car.Model == carModel)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
            }

            List<Car> cars = catalogue.Cars.Where(x => x.Type == "car").ToList();
            List<Car> trucks = catalogue.Cars.Where(x => x.Type == "truck").ToList();

            double carsHp = 0;

            foreach (Car car in cars)
            {
                carsHp += car.HorsePower;
            }

            double trucksHp = 0;
            
            foreach (Car truck in trucks)
            {
                trucksHp += truck.HorsePower;
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHp / cars.Count:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHp / trucks.Count:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
        }
    }

    
    class Car
    {
        public string Type {get; set;}
        public string Model {get; set;}
        public string Color {get; set;}
        public double HorsePower {get; set;}
    
        public Car(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        

        public override string ToString()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            
            string[] message = new String[]
            {
                $"Type: {textInfo.ToTitleCase(this.Type)}",
                $"Model: {this.Model}",
                $"Color: {this.Color}",
                $"Horsepower: {this.HorsePower}"
            };
            return $"{string.Join("\n", message)}";
        }
    }
    class Catalogue
    {
        public List<Car> Cars = new List<Car>();
    }
}