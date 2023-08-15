using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Superhero003.Repository.Database;
using Superhero003.Repository.Entities;
using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Superheroes003.Test
{
    /// <summary>
    /// 1) We have to simulate the database - ctor - create our dummy data
    /// UseInMemoryDatabase - install package MS.EFCore.InMemory (I think)
    /// 
    /// 2) code the functions AAA
    /// 
    /// 
    /// </summary>
    public class RepositoryTest
    {
        public DatabaseContext context;
        public DbContextOptions<DatabaseContext> options;
        public RepositoryTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "dummyDatabase")
                .Options;
            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();
            context.Hero.Add(new Hero
            {
                Id = 1,
                Name = "Bo",
                RealName = "Hansi",
                Place = "sted",
                DebutYear = DateTime.Now
            });
            context.Hero.Add(new Hero
            {
                Id = 4,
                Name = "Ib",
                RealName = "Hansi",
                Place = "sted",
                DebutYear = DateTime.Now
            });
            context.Hero.Add(new Hero
            {
                Id = 33,
                Name = "Ulla",
                RealName = "Hansi",
                Place = "sted",
                DebutYear = DateTime.Now
            });
            context.SaveChanges();
        }
        [Fact] 
        public async void IsGetAllNotNull()
        {
            // Arrange
            // TODO
            // object
            //context = null;
            HeroRepository hero = new HeroRepository(context);

            // Act
            // result => Invoke
            var result = await hero.GetAll();
            // Assert
            // NotNull()
            Assert.NotNull(result);
        }

        [Fact]
        public async void IsGetAllNull()
        {
            // Arrange
            // TODO
            // object
            context = null;
            HeroRepository hero = new HeroRepository(context);

            // Act
            // result => Invoke
            var result = await hero.GetAll();
            // Assert
            // NotNull()
            Assert.Null(result);
        }

        [Fact]
        public async Task IsGetAllThrowException()
        {
            context = null;
            HeroRepository hero = new HeroRepository(context);

            // Act
            // result => Invoke
            var result = await hero.GetAll();
            // Assert
            // NotNull()
            Assert.Throws<NullReferenceException>(() => result);
            //Assert.Throws()
        }

        [Fact]
        public async void IsGetAllReturningAllValues()
        {
            // Arrange
            HeroRepository hero = new HeroRepository(context);

            // Act
            var result = await hero.GetAll();
            // Assert
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public async Task GetByIdNotExist() { }
        [Fact]
        public async Task GetByIdExist() { }
        [Fact]
        public async void CreateHero() { 
        // we have to add a hero
            HeroRepository hero = new HeroRepository(context);
            Hero hero1 = new Hero()
            {
                Id = 5,
                Name = "Alex",
                RealName = "Han Solo",
                Place = "Mars",
                DebutYear = DateTime.Now
            };
            // act
             hero.CreateHero(hero1);
           

            // Assert
            var result1 = JsonConvert.SerializeObject(hero1);
            var result2 = JsonConvert.SerializeObject(hero.GetById(5).Result);
            //Assert.True(hero1.Id == 5);
            Assert.Equal(result1,result2);
           
        }
        [Fact]
        public async Task DeleteReturnTrue() {
            HeroRepository hero = new HeroRepository(context);
            bool result = await hero.DeleteHero(1);
            Assert.True(result);
        }
        [Fact]
        public async Task DeleteReturnFalse()
        {
            HeroRepository hero = new HeroRepository(context);
            bool result = await hero.DeleteHero(5555);
            Assert.True(!result);          
        }
    }
}
