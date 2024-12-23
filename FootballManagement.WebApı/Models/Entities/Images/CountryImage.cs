namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CountryImage : Entity<Guid>
    {
        public Guid CountryId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Country Country { get; set; }

        public string Url { get; set; }

        // Zaman damgaları (isteğe bağlı)
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Yapıcı metot
        public CountryImage()
        {
            // Varsayılan değerler, gerekirse başka başlatmalar yapılabilir
        }

        // Dönüştürme metodları (DTO'dan entity'ye dönüş)
        public static implicit operator CountryImage(CountryImageAddRequestDto dto)
        {
            return new CountryImage
            {
                CountryId = dto.CountryId,
                Url = dto.Url
            };
        }
    }
}
