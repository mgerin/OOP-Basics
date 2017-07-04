namespace _07.SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var car = new Car()
                              {
                                  Model = carInfo[0],
                                  FuelAmount = int.Parse(carInfo[1]),
                                  FuelConsumption = double.Parse(carInfo[2]),
                                  DistanceTraveled = 0
                              };
                cars.Add(car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var carTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = carTokens[1];
                var amount = int.Parse(carTokens[2]);

                Car.Drive(cars, model, amount);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
