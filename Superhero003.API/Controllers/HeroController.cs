using Microsoft.AspNetCore.Mvc;
using Superhero003.Repository.Interfaces;
using Superhero003.Repository.Models;
using Superhero003.Service.Interfaces;

namespace Superhero003.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {

        public IHeroService heroServie { get; set; }
        public HeroController(IHeroService temp)
        {
            this.heroServie = temp;
        }

        [HttpGet]
        public Task<List<Hero>> GetAll()
        {
            return heroServie.GetAll();
        }
        [HttpGet("GetThe3First")]
        public Task<List<Hero>> GetAllDTO()
        {
            return heroServie.GetAllDTO();
        }

        //[HttpGet("{id}")]
        //public Task<Hero> GetById(int id)
        //{
        //    return this.heroServie.GetById(id);
        //}

        //[HttpGet("bandit")]
        //public Task<Hero> GetByName(string name)
        //{
        //    return heroServie.GetByName(name);
        //}

        [HttpPost]
        public void CreateHero(Hero hero)
        {
            heroServie.CreateHero(hero);
        }

        [HttpPut()]
        public Task<Hero> UpdateHero(Hero hero)
        {
            return heroServie.UpdateHero(hero);
        }
        //[HttpDelete]
        //public Task<ActionResult<bool>> DeleteHero(int id)
        //{
        //    heroRepository.DeleteHero(id);
        //    return OkResult(true);
        //}

        //Task<bool> IHeroRepository.DeleteHero(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}




