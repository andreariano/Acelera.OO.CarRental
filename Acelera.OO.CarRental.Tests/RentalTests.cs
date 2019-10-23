using Acelera.OO.CarRental.Models.Additions;
using Acelera.OO.CarRental.Models.Rentals;
using Acelera.OO.CarRental.Models.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class RentalTests
    {
        [TestMethod]
        public void MotorHomeWithSomeAdditionsRentalTest()
        {
            var vehicleSelection = VehicleSelection
                .New()
                .WithVehicle<MotorHome>()
                .WithAddition<GPS>()
                .WithAddition<Fridge>();

            var rentalPeriod = RentalPeriod
                .New()
                .WithKilometerEstimation(850)
                .WithPickUpDate(DateTime.Now)
                .WithDropOffDate(DateTime.Now.AddDays(2));

            var rental = Rental
                .New()
                .WithVehicleSelection(vehicleSelection)
                .WithRentalPeriod(rentalPeriod);

            Assert.AreEqual(rental.CalculateRentalTotal(), 1437.50M);
        } 
    }
}
