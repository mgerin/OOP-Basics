namespace _08.RawData
{
    using System.Collections.Generic;

    public class Car
    {
        public Car()
        {
            this.Tires = new List<Tire>(4);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }
    }
}
