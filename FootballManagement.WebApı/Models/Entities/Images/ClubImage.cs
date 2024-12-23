using FootballManagement.WebApi.Models.Dtos.Images;
using FootballManagement.WebApi.Models.Dtos.Players.Image;

namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class ClubImage : Entity<Guid>
    {
        public int ClubId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Club Club { get; set; }

        public string LogoUrl { get; set; }



        public static implicit operator ClubImage(ClubImageAddRequestDto dto)
        {
            return new ClubImage { ClubId = dto.ClubId };
        }
    }
}
