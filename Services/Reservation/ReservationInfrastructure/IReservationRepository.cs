using ReservationTypes;

namespace ReservationInfrastructure
{
    public interface IReservationRepository
    {
        ReservationDTO GetReservationById(int id);
    }
}
