using Acelera.OO.CarRental.Models.Additions;

namespace Acelera.OO.CarRental.Models.Vehicles
{
    public interface IVehicle
    {
        decimal DailyPrice { get; }

        decimal KilometerPrice { get; }

        IAvailableAdditions AvailableAdditions { get; }
    }
}
