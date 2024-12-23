namespace FootballManagement.WebApi.Models.Entities.Images
{
    public class CoachImage : Entity<Guid>
    {
        public Guid CoachId { get; set; }

        // Lazy loading için virtual yapıyoruz
        public virtual Coach Coach { get; set; }

        public string Url { get; set; }

        public static implicit operator CoachImage(CoachImageAddRequestDto dto)
        {
            return new CoachImage { CoachId = dto.CoachId };
        }
    }
}
