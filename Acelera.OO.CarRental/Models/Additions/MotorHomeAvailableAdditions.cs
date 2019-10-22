using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Additions
{
    public class MotorHomeAvailableAdditions : IAvailableAdditions
    {
        public IList<IAddition> Additions => new List<IAddition>() { new GPS(35M), new KidsCarSeat(75M), new Fridge(250M) };
    }
}
