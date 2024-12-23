namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CoachImage : Entity<Guid>
    {
        public Guid CoachId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Coach Coach { get; set; }

        public string Url { get; set; }

        // Zaman damgaları (isteğe bağlı)
     

        // Yapıcı metot
        public CoachImage()
        {
            // Varsayılan değerler, gerekirse başka başlatmalar yapılabilir
        }

        // Dönüştürme metodları (DTO'dan entity'ye dönüş)
        public static implicit operator CoachImage(CoachImageAddRequestDto dto)
        {
            return new CoachImage
            {
                CoachId = dto.CoachId,
                Url = dto.Url
            };
        }
    }
}
