using FootballManagement.WebApi.Models.Dtos.Players.Image;
using FootballManagement.WebApi.Models.Entities.Images;

namespace FootballManagement.WebApi.Models.Entities
{
    public class LeagueImage : Entity<Guid>
    {
        public int LeagueId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual League League { get; set; }





        public static implicit operator LeagueImage(LeagueImageAddRequestDto dto)
        {
            return new LeagueImage { LeagueId = dto.LeagueId };
        }
    }
}
