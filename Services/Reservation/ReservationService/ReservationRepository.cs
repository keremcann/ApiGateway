using ReservationInfrastructure;
using ReservationTypes;
using System;

namespace ReservationService
{
    public class ReservationRepository : IReservationRepository
    {
        public ReservationDTO GetReservationById(int id)
        {
            return new ReservationDTO 
            { 
                Id = id, 
                BookingId = (new Random()).Next(100), 
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(35),
                BookingDate = DateTime.Now,
                Amount = (new Random()).Next(10000)
            };
        }
    }
}
