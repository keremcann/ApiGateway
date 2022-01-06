using ContactInfrastructure;
using ContactTypes;

namespace ContactService
{
    public class ContactRepository : IContactRepository
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO { Id = id, FirstName = "Sevilay", LastName = "Tanış" };
        }
    }
}
