namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();;
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }

                List<string> info = input.Split().ToList();
                
                Tire[] newTires = new Tire[4];

                for (int i = 0; i < info.Count; i += 2)
                {
                    int year = int.Parse(info[i]);
                    double pressure = double.Parse(info[i + 1]);

                    newTires[i / 2] = new Tire(year, pressure);
                }
                tires.Add(newTires);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                string[] info = input.Split().ToArray();
                int horsePower = int.Parse(info[0]);
                double cubicCapacity = double.Parse(info[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                
                engines.Add(engine);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }

                string[] info = input.Split();
                string make = info[0];
                string model = info[1];
                int year = int.Parse(info[2]);
                double fuelQuantity = double.Parse(info[3]);
                double fuelConsumption = double.Parse(info[4]);
                int engineIndex = int.Parse(info[5]);
                int tiresIndex = int.Parse(info[5]);

                Car car = new Car(make,
                    model, year, fuelQuantity, fuelConsumption,
                    engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            
            foreach (Car car in cars)
            {
                double pressureSum = 0;
                foreach (var tire in car.Tires)
                {
                    pressureSum += tire.Pressure;
                }

                if (car.Year >= 2015 && car.Engine.HorsePower > 330 && (pressureSum >= 9 && pressureSum <= 10))
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}