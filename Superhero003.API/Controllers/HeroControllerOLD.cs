using Microsoft.AspNetCore.Mvc;
using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;

namespace Superhero003.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HeroControllerOLD : IHeroRepository
    {

        public IHeroRepository heroRepository { get; set; }
        public HeroControllerOLD(IHeroRepository temp)
        {
            this.heroRepository = temp;
        }

        [HttpGet]
        public Task<List<Hero>> GetAll()
        {
            return heroRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Task<Hero> GetById(int id)
        {
            return this.heroRepository.GetById(id);
        }

        [HttpGet("bandit")]
        public Task<Hero> GetByName(string name)
        {
            return heroRepository.GetByName(name);
        }

        [HttpPost]
        public void CreateHero(Hero hero)
        {
            heroRepository.CreateHero(hero);
        }

        //[HttpDelete]
        //public Task<ActionResult<bool>> DeleteHero(int id)
        //{
        //    heroRepository.DeleteHero(id);
        //    return OkResult(true);
        //}

        [HttpDelete]
        Task<bool> IHeroRepository.DeleteHero(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("baslfdbasldfb")]
        public Task<List<Hero>> GetAllDTO()
        {
            throw new NotImplementedException();
        }

        [HttpPut()]
        public Task<Hero> UpdateHero(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
