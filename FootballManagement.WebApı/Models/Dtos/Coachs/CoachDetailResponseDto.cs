namespace FootballManagement.WebApi.Models.Dtos.Coachs
{
    public class CoachDetailResponseDto
    {
        public Guid Id { get; init; }
        public string FullName { get; init; } // Modeldeki FullName'i kullanın.
        public string Position { get; init; } // Pozisyon bilgisi eklendi.
        public string CountryName { get; init; }
        public string ClubName { get; init; }
        public string Url { get; init; }
    }
}
