using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace cs_car_garage.Tests
{
    public class GarageTests
    {
        Garage garage;

        public GarageTests()
        {
            garage = new Garage();
        }

        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            garage.Cars.Clear();

            // Act
            garage.AddCar("Ford", "Explorer");

            // Assert
            Assert.Single(garage.Cars);

        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            Car addedCar = new Car("Ford", "Explorer");
            garage.Cars.Add(addedCar);
            int carIndex = garage.Cars.IndexOf(addedCar);

            // Act
            garage.RemoveCar(carIndex);

            // Assert
            Assert.Empty(garage.Cars);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            Car addedCar1 = new Car("Ford", "Explorer");
            addedCar1.FuelLevel = 0;
            garage.Cars.Add(addedCar1);

            Car addedCar2 = new Car("Nissan", "Sentra");
            garage.Cars.Add(addedCar2);
            addedCar2.FuelLevel = 0;

            // Act
            garage.FuelAllCars();

            // Assert
            //Assert.Equal(20, addedCar1.FuelLevel);
            //Assert.Equal(20, addedCar2.FuelLevel);

            Assert.True(garage.Cars.TrueForAll(car => car.FuelLevel == 20));

        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
