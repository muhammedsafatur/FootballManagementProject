using FootballManagement.WebApi.Models.Entities.Images;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Abstracts.IImages;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes.Images;

public sealed class PlayerImageRepository : EfRepositoryBase<PlayerImage, Guid, BaseDbContext>, IPlayerImageRepository
{
    public PlayerImageRepository(BaseDbContext context) : base(context)
    {
    }
}
