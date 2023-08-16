using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Service.Interfaces
{
    public interface IHeroService
    {
        public Task<List<Hero>> GetAll(); // signature
        public void CreateHero(Hero hero);
        public Task<List<Hero>> GetAllDTO();
    }
}
