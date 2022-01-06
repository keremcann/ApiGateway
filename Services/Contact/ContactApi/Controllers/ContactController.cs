using ContactInfrastructure;
using ContactTypes;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return contactRepository.GetContactById(id);
        }

        [HttpPost]
        public bool Post(ContactDTO contact)
        {
            if (contact.FirstName != null || contact.LastName != null || contact.Id != 0)
                return true;
            return false;
        }
    }
}
