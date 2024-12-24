using FootballManagement.WebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballManagement.WebApi.Repository.Configurations
{
    public class ClubConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.Navigation(x => x.Leagues).AutoInclude();
            builder.Navigation(x=>x.Players).AutoInclude();
        }
    }
}
