using Microsoft.EntityFrameworkCore;
using FootballManagement.WebApi.Models.Entities;
using System.Reflection;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Repository.Contexts;

public class BaseDbContext : DbContext
{

    public BaseDbContext(DbContextOptions<BaseDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


    public DbSet<Coach> Coaches{ get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<League> Leagues { get; set; }
    public DbSet<Club> Clubs { get; set; }
    public DbSet<ClubHistory> ClubHistories { get; set; }
    public DbSet<CountryImage> CountriesImages { get; set; }
    public DbSet<LeagueImage> LeagueImages { get; set; }
    public DbSet<PlayerImage> PlayerImages { get; set; }
    public DbSet<CoachImage> CoachImages { get; set; }
    public DbSet<ClubImage> ClubImages { get; set; }

}
