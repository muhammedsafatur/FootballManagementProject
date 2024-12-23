using FootballManagement.WebApi.Models.Dtos.Images;

namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class ClubImage : Entity<Guid>
    {
        public int ClubId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Club Club { get; set; }

        public string LogoUrl { get; set; }



        // Yapıcı metot
        public ClubImage()
        {
            // Varsayılan değerler, gerekirse başka başlatmalar yapılabilir
        }

        // Dönüştürme metodları
        public static implicit operator ClubImage(ClubImageAddRequestDto dto)
        {
            return new ClubImage
            {
                ClubId = dto.ClubId, 
                LogoUrl = dto.LogoUrl,
                
            };
        }
    }
}
