namespace Acelera.OO.CarRental.Models.Additions
{
    public abstract class GPS : IAddition
    {
        public GPS(decimal price)
        {
            Price = price;
        }

        public string Name => "GPS";

        public decimal Price { get; }
    }
}
