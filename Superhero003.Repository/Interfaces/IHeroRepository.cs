using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Interfaces
{
    public interface IHeroRepository
    {
        public Task<List<Hero>> GetAll(); // signature
        public Task<Hero> GetById(int id);
        public Task<Hero> GetByName(string name);
        public void CreateHero(Hero hero);
        public Task<bool> DeleteHero(int id); // PK
        public Task<List<Hero>> GetAllDTO();
        public Task<Hero> UpdateHero(Hero hero);
    }
}
