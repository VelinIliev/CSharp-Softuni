namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

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
                   $"Fuel: {this.FuelQuantity:f2}";
        }
    }
}