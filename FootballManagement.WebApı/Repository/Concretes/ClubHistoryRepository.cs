using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes
{
    public class ClubHistoryRepository : EfRepositoryBase<ClubHistory, int, BaseDbContext>, IClubHistoryRepository
    {
        public ClubHistoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
