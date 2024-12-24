using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes
{
    public sealed class LeagueRepository : EfRepositoryBase<League, int, BaseDbContext>, ILeagueRepository
    {
        public LeagueRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
