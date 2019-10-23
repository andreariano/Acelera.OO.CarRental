using System.Collections;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Models.Additions
{
    public class MotorHomeAdditions : IMotorHomeAdditions
    {
        private readonly IList<IAddition> additions;

        public MotorHomeAdditions()
        {
            additions = new List<IAddition>() { new GPS(35M), new KidsCarSeat(75M), new Fridge(250M) };
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
