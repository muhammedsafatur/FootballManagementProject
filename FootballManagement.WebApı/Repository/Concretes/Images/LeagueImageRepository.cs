using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Abstracts.IImages;
using FootballManagement.WebApi.Repository.Contexts;


namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class LeagueImageRepository : EfRepositoryBase<LeagueImage, Guid, BaseDbContext>, ILeagueImageRepository
{
    public LeagueImageRepository(BaseDbContext context) : base(context)
    {
    }
}
