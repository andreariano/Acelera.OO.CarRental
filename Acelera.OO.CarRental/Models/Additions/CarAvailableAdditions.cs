using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Additions
{
    public class CarAvailableAdditions : IAvailableAdditions
    {
        public IList<IAddition> Additions => new List<IAddition>() { new CarGPS(), new KidsCarSeat(65M) };
    }
}
