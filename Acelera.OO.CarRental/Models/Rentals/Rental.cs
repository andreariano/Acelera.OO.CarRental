using System.Linq;

namespace Acelera.OO.CarRental.Models.Rentals
{
    public class Rental : IRental
    {
        private Rental()
        {

        }

        public VehicleSelection VehicleSelection { get; private set; }

        public RentalPeriod RentalPeriod { get; private set; }

        public static Rental New()
        {
            return new Rental();
        }

        public Rental WithVehicleSelection(VehicleSelection vehicleSelection)
        {
            VehicleSelection = vehicleSelection;

            return this;
        }

        public Rental WithRentalPeriod(RentalPeriod rentalPeriod)
        {
            RentalPeriod = rentalPeriod;

            return this;
        }

        public decimal CalculateRentalTotal()
        {
            return 
                CalculateRentalDays() + 
                CalculateKilometerEstimation() + 
                CalculateSelectedAdditions();
        }

        private decimal CalculateRentalDays()
        {
            return RentalPeriod.RentalDays * VehicleSelection.Vehicle.DailyPrice;
        }

        private decimal CalculateKilometerEstimation()
        {
            return RentalPeriod.KilometerEstimation * VehicleSelection.Vehicle.KilometerPrice;
        }

        private decimal CalculateSelectedAdditions()
        {
            return VehicleSelection.SelectedAdditions.Sum(x => x.Price);
        }
    }
}
