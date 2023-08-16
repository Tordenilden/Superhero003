using Microsoft.EntityFrameworkCore;
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

        //public void CreateHero(Team hero)
        //{
        //    //
        //    throw new NotImplementedException();
        public async Task<Team> CreateTeam(Team temp)
        {
            context.Team.Add(temp);
            var res = await context.SaveChangesAsync();
            return new Team();
        }

        // my Foreign relation method
        public async Task<Team> CreateForeignRelation(Team temp)
        {
            // I put in 4 again
            // verify that 4 exists... then "update the object
            // then safe the object
            Team team = new Team();
            team = context.Team.FirstOrDefault(x => x.Id == temp.Id);
            if(temp.Heroes != null)
            {

           
            team.Name = temp.Name; //string
            team.age = temp.age; //int
                // here is all data passed.. I might want the ID, måle på 
                // om der er en eller flere
                if (temp.Heroes.Count == 1)
                {
                    team.Heroes[0].Id = temp.Heroes[0].Id;
                }
           //team.Heroes = temp.Heroes; // array
            await context.SaveChangesAsync();
            }
            // I want to create a new Hero in my team

            //context.Team.Include(t=>t.Heroes)

            if (team.Heroes == null)
            {
                Hero hero = new Hero()
                {
                    Name = "Hansi",
                    DebutYear = DateTime.Now,
                    Place = "Bornholm",
                    RealName = "abc"
                };
                team.Heroes = new List<Hero>();
                team.Heroes.Add(hero);
            }


            //context.Hero.Add(hero); // is it team 4??

            //context.Team.Add(team);
            var res = await context.SaveChangesAsync();
            return team;
        }

        public async Task<Team> CreateTeam(TeamDTO temp)
        {
            Team team = new Team();
            // teamDTO om til team
            try
            {
               
                team.Id = temp.Id;
                team.Name = temp.Name;
                team.age = 5;
                context.Team.Add(team);
                var res = await context.SaveChangesAsync();
            }
            catch (Exception ex) { throw ex; }
            return team;
        }

        #region weird stuff

        #endregion weird stuff
    }
}
