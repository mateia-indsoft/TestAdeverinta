using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonData personData;

        public PersonController(IPersonData personData)
        {
            this.personData = personData;
        }

        [HttpGet("/persons")]
        public async Task<IResult> GetPersons()
        {
            return Results.Ok(await personData.GetPersons());
        }

        [HttpGet("/person/{cnp}")]
        public async Task<IResult> GetPerson(long cnp)
        {
            return Results.Ok(await personData.GetPerson(cnp));
        }

        [HttpPost("/person")]
        public async Task<IResult> PostPerson(PersonModel person)
        {
            await personData.InsertPerson(person);
            return Results.Ok();
        }
    }
}
