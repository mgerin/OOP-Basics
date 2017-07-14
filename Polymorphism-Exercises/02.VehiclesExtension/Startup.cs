namespace _02.VehiclesExtension
{
    using System;

    using _02.VehiclesExtension.Models;

    class Startup
    {
        static void Main()
        {
            var carArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            var truckArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            var busArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandArgs[0];
                var vehicle = commandArgs[1];

                try
                {
                    if (command == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            car.Driving(double.Parse(commandArgs[2]));
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Driving(double.Parse(commandArgs[2]));
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.DrivingFull();
                            bus.Driving(double.Parse(commandArgs[2]));
                            bus.DrivingEmpty();
                        }

                    }
                    else if (command == "Refuel")
                    {
                        if (vehicle == "Truck")
                        {
                            truck.Refuel(double.Parse(commandArgs[2]));
                        }
                        else if (vehicle == "Car")
                        {
                            car.Refuel(double.Parse(commandArgs[2]));
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(double.Parse(commandArgs[2]));
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.Driving(double.Parse(commandArgs[2]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
