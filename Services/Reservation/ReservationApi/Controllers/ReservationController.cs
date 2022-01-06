using Microsoft.AspNetCore.Mvc;
using ReservationInfrastructure;
using ReservationTypes;

namespace ReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository reservationRepository;

        public ReservationController(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }

        [HttpGet("{id}")]
        public ReservationDTO Get(int id)
        {
            return this.reservationRepository.GetReservationById(id);
        }
    }
}
