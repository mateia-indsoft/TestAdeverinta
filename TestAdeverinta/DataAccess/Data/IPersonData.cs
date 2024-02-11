using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IPersonData
    {
        Task<PersonModel?> GetPerson(long cnp);
        Task<IEnumerable<PersonModel>> GetPersons();
        Task InsertPerson(PersonModel person);
    }
}