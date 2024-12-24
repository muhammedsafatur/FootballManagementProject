using FootballManagement.WebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballManagement.WebApi.Repository.Configurations
{
    public class ClubHistoryConfiguration : IEntityTypeConfiguration<ClubHistory>
    {
        public void Configure(EntityTypeBuilder<ClubHistory> builder)
        {
            builder.Navigation(x => x.Club).AutoInclude();
            builder.Navigation(x=>x.Player).AutoInclude();
            builder.Navigation(x=>x.Coach).AutoInclude();
        }
    }
}
