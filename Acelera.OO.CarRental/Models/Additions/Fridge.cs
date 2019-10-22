namespace Acelera.OO.CarRental.Models.Additions
{
    public class Fridge : IAddition
    {
        public Fridge(decimal price)
        {
            Price = price;
        }

        public string Name => "Fridge";

        public decimal Price { get; }
    }
}
