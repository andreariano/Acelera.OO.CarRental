using System;
using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Additions;
using Acelera.OO.CarRental.Models.Vehicles;

namespace Acelera.OO.CarRental.Models.Rentals
{
    public class Rental : IRental
    {
        private readonly IVehicle vehicle;
        private readonly int kilometerEstimation;
        private readonly IList<IAddition> selectedAdditions;
        private readonly DateTime pickupDate;
        private readonly DateTime dropoffDate;

        public Rental(IVehicle vehicle, int kilometerEstimation, IList<IAddition> selectedAdditions, DateTime pickupDate, DateTime dropoffDate)
        {
            this.vehicle = vehicle;
            this.kilometerEstimation = kilometerEstimation;
            this.selectedAdditions = selectedAdditions;
            this.pickupDate = pickupDate;
            this.dropoffDate = dropoffDate;
        }

        public IVehicle Vehicle => vehicle;

        public int KilometerEstimation => kilometerEstimation;

        public IList<IAddition> SelectedAdditions => selectedAdditions;

        public DateTime PickupDate => pickupDate;

        public DateTime DropOffDate => dropoffDate;
    }
}
