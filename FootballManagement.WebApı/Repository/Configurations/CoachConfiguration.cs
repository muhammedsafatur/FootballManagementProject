using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Repository.Configurations
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.Navigation(x => x.Country).AutoInclude();
            builder.Navigation(x => x.Club).AutoInclude();
            builder.Navigation(x=>x.ClubHistories).AutoInclude();
        }
    }
}
