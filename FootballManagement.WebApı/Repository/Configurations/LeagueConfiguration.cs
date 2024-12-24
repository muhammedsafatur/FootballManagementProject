using FootballManagement.WebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballManagement.WebApi.Repository.Configurations
{
    public class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.Navigation(x => x.Clubs).AutoInclude();
            builder.Navigation(x=>x.Country).AutoInclude();
            builder.Navigation(x=>x.Coachs).AutoInclude();
         }
    }
}
