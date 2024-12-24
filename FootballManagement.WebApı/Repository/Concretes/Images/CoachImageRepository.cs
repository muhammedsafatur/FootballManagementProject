

using FootballManagement.WebApi.Models.Entities.Images;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Abstracts.IImages;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class CoachImageRepository : EfRepositoryBase<CoachImage, Guid, BaseDbContext>, ICoachImageRepository
{
    public CoachImageRepository(BaseDbContext context) : base(context)
    {
    }
}
