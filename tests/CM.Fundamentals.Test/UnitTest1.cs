using System;
using Xunit;

namespace CM.Fundamentals.Test
{
    public class CarTests
    {
        [Fact]
        public void ShouldCreateCar()
        {
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2021;
            car.Odometer = 10000;

            Assert.Equal("Toyota", car.Make);
            Assert.Equal("Camry", car.Model);
            Assert.Equal(2021, car.Year);
            Assert.Equal(10000, car.Odometer);
        }

        [Theory]
        [InlineData("Toyota", "Camry")]
        [InlineData("Toyota", "Corolla")]
        public void ShouldCreateCarWithArg(string make, string model)
        {
            Car car = new Car();
            car.Make = make;
            car.Model = model;
            car.Year = 2021;
            car.Odometer = 10000;

            Assert.Equal(make, car.Make);
            Assert.Equal(model, car.Model);
            Assert.Equal(2021, car.Year);
            Assert.Equal(10000, car.Odometer);
        }

        [Fact]
        public void ShouldCreateCarSedan()
        {
            Sedan car = new Sedan();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2021;
            car.Odometer = 10000;

            Assert.Equal("Toyota", car.Make);
            Assert.Equal("Camry", car.Model);
            Assert.Equal(2021, car.Year);
            Assert.Equal(10000, car.Odometer);
            Assert.Equal(VehicleClassification.Sedan, car.Type);
        }

        [Fact]
        public void ShouldCreateCarTruck()
        {
            Truck car = new Truck();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2021;
            car.Odometer = 10000;

            Assert.Equal("Toyota", car.Make);
            Assert.Equal("Camry", car.Model);
            Assert.Equal(2021, car.Year);
            Assert.Equal(10000, car.Odometer);
            Assert.Equal(VehicleClassification.Truck, car.Type);
        }
    }
}
