namespace Acelera.OO.CarRental.Models.Additions
{
    public class KidsCarSeat : IAddition
    {
        public KidsCarSeat(decimal price)
        {
            Price = price;
        }

        public string Name => "Kids Car Seat";

        public decimal Price { get; }
    }
}
