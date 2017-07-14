namespace _01.Vehicles
{
    using System;

    using _01.Vehicles.Models;

    class Startup
    {
        static void Main()
        {
            var carArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));
            var truckArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var cmdArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var cmd = cmdArgs[0];
                var vehicle = cmdArgs[1];

                if (cmd == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        car.Driving(double.Parse(cmdArgs[2]));
                    }
                    else
                    {
                        truck.Driving(double.Parse(cmdArgs[2]));
                    }
                }
                else if (cmd == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(double.Parse(cmdArgs[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(cmdArgs[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car}");
            Console.WriteLine($"Truck: {truck}");
        }
    }
}
