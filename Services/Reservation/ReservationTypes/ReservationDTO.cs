using System;

namespace ReservationTypes
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public double Amount { get; set; }
    }
}
