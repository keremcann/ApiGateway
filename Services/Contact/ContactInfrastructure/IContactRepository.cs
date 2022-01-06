using ContactTypes;

namespace ContactInfrastructure
{
    public interface IContactRepository
    {
        ContactDTO GetContactById(int id);
    }
}
