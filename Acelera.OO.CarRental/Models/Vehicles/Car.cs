using Acelera.OO.CarRental.Models.Additions;

namespace Acelera.OO.CarRental.Models.Vehicles
{
    public class Car: ICar
    {
        public decimal DailyPrice => 50M;

        public decimal KilometerPrice => 0.50M;

        public IAdditionsList AvailableAdditions => new CarAdditions();
    }
}
