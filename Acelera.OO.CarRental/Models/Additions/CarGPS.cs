namespace Acelera.OO.CarRental.Models.Additions
{
    public class CarGPS : GPS
    {
        private const decimal BasePrice = 25M;

        public CarGPS() : base(BasePrice)
        {
        }
    }
}
