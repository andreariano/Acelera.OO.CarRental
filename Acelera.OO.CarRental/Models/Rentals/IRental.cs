using Acelera.OO.CarRental.Models.Additions;
using Acelera.OO.CarRental.Models.Vehicles;
using System;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Rentals
{
    public interface IRental
    {
        IVehicle Vehicle { get; }

        int KilometerEstimation { get; }

        IList<IAddition> SelectedAdditions { get; }

        DateTime PickupDate { get; }

        DateTime DropOffDate { get; }
    }
}
