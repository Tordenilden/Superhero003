using Microsoft.AspNetCore.Mvc;
using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;

namespace Superhero003.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HeroController : IHeroRepository
    {
        public IHeroRepository heroRepository { get; set; }
        public HeroController(IHeroRepository temp)
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

        [HttpDelete]
        public void DeleteHero(int id)
        {
            heroRepository.DeleteHero(id);
        }
    }
}
