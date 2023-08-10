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
    public class HeroRepository : IHeroRepository
    {
        //CRUD + something more...
        DatabaseContext context { get; set; }
        public HeroRepository(DatabaseContext temp) // ??
        {
            context = temp;
        }
        public async Task<List<Hero>> GetAll() {
            return await context.Hero.ToListAsync();
        }

        public async Task<Hero> GetById(int id)
        {
            var hero = await context.Hero.FirstOrDefaultAsync(h => h.Id == id);
            return hero;

        }

        public async Task<Hero> GetByName(string name)
        {
            return await context.Hero?.FirstOrDefaultAsync(h => h.Name == name);
        }

        public void CreateHero(Hero hero)
        {
            context.Hero.Add(hero);
            context.SaveChanges(); // this is commit
            //return hero;
        }

        public void DeleteHero(int id)
        {
            var hero = context.Hero?.FirstOrDefault(h => h.Id == id);
            context.Hero?.Remove(hero);
            context.SaveChanges();
        }
    }
}
