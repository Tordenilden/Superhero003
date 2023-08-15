using Superhero003.Repository.Database;
using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Entities
{
    public class TeamRepository: ITeamRepository
    {
        DatabaseContext context { get; set; }
        public TeamRepository(DatabaseContext temp) // ??
        {
            context = temp;
        }

        public Task<List<Team>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateHero(Team hero)
        {
            //
            throw new NotImplementedException();
        }
    }
}
