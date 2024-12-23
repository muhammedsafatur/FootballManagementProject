namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class PlayerImage : Entity<Guid>
    {
        public Guid PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public string Url { get; set; }

        // Zaman damgaları (isteğe bağlı)
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Yapıcı metot
        public PlayerImage()
        {
            // PlayerId gibi zorunlu özelliklerin varsayılan değerlerini başlatıyoruz.
        }

        // Dönüştürme metodları
        public static implicit operator PlayerImage(PlayerImageAddRequestDto dto)
        {
            return new PlayerImage
            {
                PlayerId = dto.PlayerId,
                Url = dto.Url
            };
        }
    }
}
