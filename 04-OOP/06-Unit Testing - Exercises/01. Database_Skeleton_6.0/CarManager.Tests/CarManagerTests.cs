using System;

namespace CarManager.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CarManagerTests
    {
        [Test]
        public void TestCreateNewCarSuccess()
        {
            Car car = new Car("Ford", "Focus", 5, 50);
            
            Assert.That(car.Make, Is.EqualTo("Ford"));
            Assert.That(car.Model, Is.EqualTo("Focus"));
            Assert.That(car.FuelConsumption, Is.EqualTo(5));
            Assert.That(car.FuelCapacity, Is.EqualTo(50));
        }
        [Test]
        public void TestCreateNewCarWithMakeEmptyStringAndNull()
        {
            Assert.Throws<ArgumentException>(
                () => new Car("", "Focus", 5, 50), "Make cannot be null or empty!"); 
            
            Assert.Throws<ArgumentException>(
                () => new Car(null, "Focus", 5, 50), "Make cannot be null or empty!");
        }
        
        [Test]
        public void TestCreateNewCarWithModelEmptyStringAndNull()
        {
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", "", 5, 50), "Make cannot be null or empty!"); 
            
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", null, 5, 50), "Make cannot be null or empty!");
        }
        
        [Test]
        public void TestCreateNewCarWithFuelConsumptionZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", "Focus", 0, 50), "Fuel consumption cannot be zero or negative!"); 
            
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", "Focus", -1, 50), "Fuel consumption cannot be zero or negative!");
        }
        [Test]
        public void TestCreateNewCarWithFueCapacityZeroAndNegative()
        {
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", "Focus", 5, 0), "Fuel amount cannot be negative!"); 
            
            Assert.Throws<ArgumentException>(
                () => new Car("Ford", "Focus", 5, -10), "Fuel amount cannot be negative!");
        }
        [Test]
        public void TestRefuelSuceess()
        {
            Car car = new Car("Ford", "Focus", 5, 50);
            car.Refuel(10);

            Assert.That(car.FuelAmount, Is.EqualTo(10));
        }
        
        [Test]
        public void TestRefuelWithZeroAndNegative()
        {
            Car car = new Car("Ford", "Focus", 5, 50);

            Assert.Throws<ArgumentException>(
                () =>  car.Refuel(0), "Fuel amount cannot be negative!"); 
            
            Assert.Throws<ArgumentException>(
                () =>  car.Refuel(-10), "Fuel amount cannot be negative!");
        }
        [Test]
        public void TestDriveSuccess()
        {
            Car car = new Car("Ford", "Focus", 5, 50);
            car.Refuel(10);
            car.Drive(10);
            
            var actualResult = car.FuelAmount;
            var expectedResult =9.5;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void TestDriveWithoutFuel()
        {
            Car car = new Car("Ford", "Focus", 5, 50);
            
            Assert.Throws<InvalidOperationException>(
                () =>  car.Drive(10), "You don't have enough fuel to drive!");
        }
    }
}