using FootballManagement.WebApi.Models.Dtos.Players;

namespace FootballManagement.WebApi.Models.Dtos.Clubs
{
    public class ClubDetailResponseDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string YearOfEstablishment { get; init; }

        public string? CountryName { get; init; }
        public string? LeagueName { get; init; }
        public string? LogoUrl { get; init; }
        public List<PlayerResponseDto> Players { get; init; } 
    }
}
