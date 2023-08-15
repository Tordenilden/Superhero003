using Microsoft.EntityFrameworkCore;
using Superhero003.Repository.Models;

namespace Superhero003.Repository.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> option)
        : base(option)
    {
    }

    // tables in DB
    public DbSet<Hero> Hero { get; set; }
    public DbSet<Team> Team { get; set; }

}
