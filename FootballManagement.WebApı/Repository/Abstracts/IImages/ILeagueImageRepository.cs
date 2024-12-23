using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;

namespace FootballManagement.WebApi.Repository.Abstracts.IImages
{
    public interface ILeagueImageRepository : IRepository<LeagueImage, Guid>
    {
    }
}
