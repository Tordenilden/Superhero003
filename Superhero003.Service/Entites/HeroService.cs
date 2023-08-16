using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;
using Superhero003.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Service.Entities
{
    /// <summary>
    /// - Logik , dvs tælle data, statistik, blabla
    /// - Team => and dismantle it to Hero and Team
    /// - User (Password + something else) => something else (avoid password)
    /// </summary>
    public class HeroService : IHeroService
    {
        public IHeroRepository heroRepository { get; set; }
        public HeroService(IHeroRepository heroservice)
        {
            heroRepository = heroservice;
        }


        public void CreateHero(Hero hero)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transformation (or logik)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Hero>> GetAll()
        {
            return heroRepository.GetAll();
            // return all
            // and after, try to change GetAll to only return 1-2 or
            // something else (it can be another method)
        }
        public async Task<List<Hero>> GetAllDTO()
        {
            //logik get all but first 3

            return await heroRepository.GetAllDTO();
        }

        public async Task<List<Hero>> GetAllServiceDoTheJob()
        {
            //logik get all but first 3
            List<Hero> heroList = await heroRepository.GetAll();
            // draw the first 3 out of the collection!!
            List<Hero> temp = heroList.Where(hero => hero.Id >= 1 && hero.Id <=3).ToList();
            return temp;
        }
    }
}
