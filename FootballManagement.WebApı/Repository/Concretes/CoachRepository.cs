using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;
namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class CoachRepository : EfRepositoryBase<Coach, Guid, BaseDbContext>, ICoachRepository
{
    public CoachRepository(BaseDbContext context) : base(context)
    {
    }
}
