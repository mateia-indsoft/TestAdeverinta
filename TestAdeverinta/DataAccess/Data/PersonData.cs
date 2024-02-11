using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;



public class PersonData : IPersonData
{
    private readonly ISqlDataAccess db;

    public PersonData(ISqlDataAccess db)
    {
        this.db = db;
    }

    public async Task<IEnumerable<PersonModel>> GetPersons()
    {
        return await db.LoadData<PersonModel, dynamic>("dbo.spPerson_GetAll", new { });
    }

    public async Task<PersonModel?> GetPerson(long cnp)
    {
        return (await db.LoadData<PersonModel, dynamic>("dbo.spPerson_Get", new { CNP = cnp })).FirstOrDefault();
    }

    public Task InsertPerson(PersonModel person)
    {
        return db.SaveData("dbo.spPerson_Insert", new {person.Id, person.CNP, person.FirstName, person.LastName });
    }
}
