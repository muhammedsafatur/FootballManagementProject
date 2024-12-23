using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;

namespace SporManagmenet.WebApi.Repository.Abstracts;

public interface ICountryRepository : IRepository<Country,int>
{
}
