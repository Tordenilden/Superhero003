using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Interfaces
{
    public interface ITeamRepository
    {
        public Task<List<Team>> GetAll(); // signature
        public Task<Team> GetById(int id);
        public Task<Team> CreateTeam(TeamDTO hero);
        public Task<Team> CreateTeam(Team temp);
        public Task<Team> CreateForeignRelation(Team temp);


    }
}
