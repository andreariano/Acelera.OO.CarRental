using Acelera.OO.CarRental.Models.Additions;
using Acelera.OO.CarRental.Models.Vehicles;
using System.Collections.Generic;
using System.Linq;

namespace Acelera.OO.CarRental.Models.Rentals
{
    public class VehicleSelection
    {
        private VehicleSelection()
        {
            SelectedAdditions = new List<IAddition>();
        }

        public IVehicle Vehicle { get; private set; }

        public IList<IAddition> SelectedAdditions { get; }

        public static VehicleSelection New()
        {
            return new VehicleSelection();
        }

        public VehicleSelection WithVehicle<T>() where T : IVehicle, new()
        {
            Vehicle = new T();

            return this;
        }

        public VehicleSelection WithAddition<T>() where T : IAddition
        {
            SelectedAdditions.Add(Vehicle.AvailableAdditions.First(x => x.GetType() == typeof(T)));

            return this;
        }
    }
}
