using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;


namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class ClubRepository : EfRepositoryBase<Club, int, BaseDbContext>, IClubRepository
{
    public ClubRepository(BaseDbContext context) : base(context)
    {
    }
}
