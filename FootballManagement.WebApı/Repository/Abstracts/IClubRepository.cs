using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
    
namespace FootballManagement.WebApi.Repository.Abstracts;

public interface IClubRepository : IRepository<Club,int>
{

}
