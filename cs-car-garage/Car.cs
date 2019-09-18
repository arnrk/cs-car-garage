using System;
using System.Collections.Generic;
using System.Text;

namespace cs_car_garage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }

        public Car()
        {

        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Speed = 0;
            FuelLevel = 100;
        }

        public void Accelerate()
        {
            // Speed = Speed + 10;
            Speed += 10;
            FuelLevel -= 2;
        }

        public void AddFuel()
        {
            FuelLevel += 20;
        }
    }
}
