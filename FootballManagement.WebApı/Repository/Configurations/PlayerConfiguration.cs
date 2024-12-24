using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Repository.Configurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.Navigation(x => x.Country).AutoInclude();
        builder.Navigation(x => x.Club).AutoInclude();
    }
}
