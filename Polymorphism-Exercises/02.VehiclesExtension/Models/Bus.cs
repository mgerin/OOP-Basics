namespace _02.VehiclesExtension.Models
{
    using System;

    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            
        }

        public override void Refuel(double liters)
        {
            if (base.FuelQuantity + liters > base.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            base.Refuel(liters);
        }

        public void DrivingFull()
        {
            base.FuelConsumption += 1.4;
        }

        public void DrivingEmpty()
        {
            base.FuelConsumption -= 1.4;
        }
    }
}
