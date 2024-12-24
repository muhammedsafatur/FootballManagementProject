
using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class PlayerRepository : EfRepositoryBase<Player, Guid, BaseDbContext>, IPlayerRepository
{
    public PlayerRepository(BaseDbContext context) : base(context)
    {
    }
}
