using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Additions
{
    public interface IAvailableAdditions
    {
        IList<IAddition> Additions { get; }
    }
}
