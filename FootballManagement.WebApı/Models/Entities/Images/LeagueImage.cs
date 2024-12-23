namespace FootballManagement.WebApi.Models.Entities
{
    public class LeagueImage : Entity<Guid>
    {
        public Guid LeagueId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual League League { get; set; }

        public string Url { get; set; }

     

        // Yapıcı metot
        public LeagueImage()
        {
            // Varsayılan değerler, gerekirse başka başlatmalar yapılabilir
        }

        // Dönüştürme metodları (DTO'dan entity'ye dönüş)
        public static implicit operator LeagueImage(LeagueImageAddRequestDto dto)
        {
            return new LeagueImage
            {
                LeagueId = dto.LeagueId,
                Url = dto.Url
            };
        }
    }
}
