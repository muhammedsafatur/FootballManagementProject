using FootballManagement.WebApi.Models.Dtos.Players.Image;

namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CountryImage : Entity<Guid>
    {
        public int CountryId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Country Country { get; set; }

        public string Url { get; set; }

        public static implicit operator CountryImage(CountryImageAddRequestDto dto)
        {
            return new CountryImage { CountryId = dto.CountryId };
        }
    }
}
