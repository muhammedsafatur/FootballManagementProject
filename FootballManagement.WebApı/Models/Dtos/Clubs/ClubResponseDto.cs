using FootballManagement.WebApi.Models.Dtos.Players;
using FootballManagement.WebApi.Models.Entities;

namespace FootballManagement.WebApi.Models.Dtos.Clubs
{
    public sealed record ClubResponseDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string YearOfEstablishment { get; init; }

        // Opsiyonel alanlar
        public string? CountryName { get; init; }
        public string? LeagueName { get; init; }
        public string? LogoUrl { get; init; }
        public List<PlayerResponseDto> Players { get; init; } = new List<PlayerResponseDto>();

        public static implicit operator ClubResponseDto(Club club)
        {
            return new ClubResponseDto
            {
                Id = club.Id,
                Name = club.Name,
                YearOfEstablishment = club.YearOfEstablishment,
                LeagueName = club.League?.LeagueName,  // Eğer bir lig varsa, adını al
                LogoUrl = club.LogoUrl,  // Eğer kulüp logosu varsa
                Players = club.Players?.Select(p => new PlayerResponseDto(p)).ToList()  // Kulüp oyuncuları DTO'su şeklinde
            };
        }
    }
}
