using System;

namespace Acelera.OO.CarRental.Models.Rentals
{
    public class RentalPeriod
    {
        private RentalPeriod()
        {
            PickUpDate = DateTime.Now;
            DropOffDate = PickUpDate.AddDays(1);
        }

        public DateTime PickUpDate { get; private set; }

        public DateTime DropOffDate { get; private set; }

        public int KilometerEstimation { get; private set; }
        
        public int RentalDays => Convert.ToInt32((DropOffDate - PickUpDate).TotalDays);

        public static RentalPeriod New()
        {
            return new RentalPeriod();
        }

        public RentalPeriod WithKilometerEstimation(int kilometers)
        {
            KilometerEstimation = kilometers;

            return this;
        }

        public RentalPeriod WithPickUpDate(DateTime pickUpDate)
        {
            PickUpDate = pickUpDate;

            return this;
        }

        public RentalPeriod WithDropOffDate(DateTime dropOffDate)
        {
            DropOffDate = dropOffDate;

            return this;
        }
    }
}
