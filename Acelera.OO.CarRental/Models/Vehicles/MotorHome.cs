using Acelera.OO.CarRental.Models.Additions;

namespace Acelera.OO.CarRental.Models.Vehicles
{
    public class MotorHome: IMotorHome
    {
        public decimal DailyPrice => 300M;

        public decimal KilometerPrice => 0.65M;

        public IAdditionsList AvailableAdditions => new MotorHomeAdditions();
    }
}
