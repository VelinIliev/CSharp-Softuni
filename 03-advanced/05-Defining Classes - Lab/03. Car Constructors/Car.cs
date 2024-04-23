namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

         public Car()
            : this("VW", "Golf", 2025, 200, 10)
        {

        }
         public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        
        public void Drive(double distance)
        {
            double neededFuel = FuelConsumption * distance;

            if (this.FuelQuantity - neededFuel <= 0)
            {
                throw new InvalidOperationException("Not enough fuel!");
            }

            this.FuelQuantity -= neededFuel;
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\n" +
                   $"Model: {this.Model}\n" +
                   $"Year: {this.Year}\n" +
                   $"Fuel: {this.FuelQuantity}";
        }
    }
}