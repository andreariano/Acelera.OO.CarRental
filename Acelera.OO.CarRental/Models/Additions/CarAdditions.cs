using System.Collections;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Additions
{
    public class CarAdditions : ICarAdditions
    {
        private readonly IList<IAddition> additions;

        public CarAdditions()
        {
            additions = new List<IAddition>() { new GPS(25M), new KidsCarSeat(65M) };
        }

        public IEnumerator<IAddition> GetEnumerator()
        {
            return additions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return additions.GetEnumerator();
        }
    }
}
