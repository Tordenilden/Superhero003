using Microsoft.AspNetCore.Mvc;
using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Superhero003.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        public ITeamRepository teamRepository { get; set; }
        public TeamController(ITeamRepository temp)
        {
            this.teamRepository = temp;
        }




        // GET: api/<TeamController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeamController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeamController>
        [HttpPost("create")]
        public async Task<Team> Create(Team value)//[Frombody] forms
        {
            return await teamRepository.CreateTeam(value);
        }

        [HttpPost("mathias")]
        public async Task Post(TeamDTO value)//[Frombody] forms
        {
            await teamRepository.CreateTeam(value);        
        }

        [HttpPost("CreateForeignRelation")]
        public async Task<Team> CreateForeignRelation(Team value)//[Frombody] forms
        {
            return await teamRepository.CreateForeignRelation(value);
        }


        // PUT api/<TeamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
