namespace _07.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumption { get; set; }

        public int DistanceTraveled { get; set; }

        public static void Drive(List<Car> cars, string model, int amount)
        {
            var currentCar = cars.FirstOrDefault(c => c.Model == model);
            if (currentCar.FuelAmount >= amount * currentCar.FuelConsumption)
            {
                cars.FirstOrDefault(c => c.Model == model).FuelAmount -= amount * currentCar.FuelConsumption;
                cars.FirstOrDefault(c => c.Model == model).DistanceTraveled += amount;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
