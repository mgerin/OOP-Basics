namespace _01.Vehicles.Models
{
    using System;

    class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        private double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }

        public void Driving(double distance)
        {
            if (distance * this.FuelConsumption <= this.FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.FuelQuantity:F2}";
        }
    }
}
