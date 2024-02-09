using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;



public class PersonData
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

    public async Task<PersonModel?> GetPerson(int id)
    {
        return (await db.LoadData<PersonModel, dynamic>("dbo.spPerson_Get", new {Id = id})).FirstOrDefault();
    }

    public Task InsertUser(PersonModel person)
    {
        return db.SaveData("dbo.spPerson_Insert", new { person.CNP, person.FirstName, person.LastName});
    }
}
