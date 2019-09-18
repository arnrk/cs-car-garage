using System;
using System.Collections.Generic;
using System.Text;

namespace cs_car_garage
{
    public class Garage
    {
        public List<Car> Cars = new List<Car>();

        public void AddCar(string make, string model)
        {
            Car car = new Car(make, model);
            Cars.Add(car);
        }

        public void RemoveCar(int index)
        {
            Cars.RemoveAt(index);
        }

        public void FuelAllCars()
        {
            foreach (Car car in Cars)
            {
                car.AddFuel();
            }
        }
    }
}
