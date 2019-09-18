using System;
using Xunit;

namespace cs_car_garage.Tests
{
    public class CarTests
    {
        Car car;

        public CarTests()
        {
            car = new Car();
        }

        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed by 10
            // Arrange
            // Car car = new Car();
            car.Speed = 0;

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(10, car.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount by 2
            // Arrange
            car.FuelLevel = 100;

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(98, car.FuelLevel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            car.FuelLevel = 0;

            // Act
            car.AddFuel();

            // Assert
            Assert.Equal(20, car.FuelLevel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            // Act
            // Assert
        }
    }
}
