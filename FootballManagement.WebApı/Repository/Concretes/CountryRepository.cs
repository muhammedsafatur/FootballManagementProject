using FootballManagement.WebApi.Models.Entities;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Abstracts.EfBases;
using FootballManagement.WebApi.Repository.Contexts;

namespace FootballManagement.WebApi.Repository.Concretes;

public sealed class CountryRepository : EfRepositoryBase<Country, int, BaseDbContext>, ICountryRepository
{
    public CountryRepository(BaseDbContext context) : base(context)
    {
    }
}
